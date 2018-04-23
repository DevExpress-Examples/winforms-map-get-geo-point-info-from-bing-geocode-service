using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace RequestLocationInformation {
    public partial class Form1 : Form {

        double latitude;
        double longitude;
        const string yourBingKey = "INSERT_YOUR_BING_KEY_HERE";
        BingGeocodeDataProvider geocodeProvider;
        MapControl map;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            PrepareMap();
            geocodeProvider.LocationInformationReceived +=
               new LocationInformationReceivedEventHandler(geocodeProvider_LocationInformationReceived);
        }

        #region #CustomRequestUI
        private void requestLocation_Click(object sender, System.EventArgs e) {
            if (GetLocationArguments()) {
                geocodeProvider.RequestLocationInformation(new GeoPoint(latitude, longitude), 0);
            }
        }

        private bool GetLocationArguments() {
            latitude = String.IsNullOrEmpty(tbLatitude.Text) ? 0 : Double.Parse(tbLatitude.Text);
            if ((latitude > 90) || (latitude < -90)) {
                MessageBox.Show("Latitude must be less than or equal to 90 and greater than or equal to - 90. Correct the input value.");
                return false;
            }

            longitude = String.IsNullOrEmpty(tbLongitude.Text) ? 0 : Double.Parse(tbLongitude.Text);
            if ((longitude > 180) || (longitude < -180)) {
                MessageBox.Show("Longitude must be less than or equal to 180 and greater than or equal to - 180. Correct the input value.");
                return false;
            }
            return true;
        }
        #endregion #CustomRequestUI

        #region #CustomRecievedUI
        private void geocodeProvider_LocationInformationReceived(object sender, LocationInformationReceivedEventArgs e) {
            GeocodeRequestResult result = e.Result;

            if (result.Locations.Length > 0) {
                NavigateTo(result.Locations[0].Location);
            }
            DisplayResult(result);
        }

        void NavigateTo(GeoPoint geoPoint) {
            map.CenterPoint = geoPoint;
            map.ZoomLevel = 7;
        }

        private void DisplayResult(GeocodeRequestResult result) {
            StringBuilder resultList = new StringBuilder("");
            int resCounter = 1;

            if (result.ResultCode == RequestResultCode.Success) {

                foreach (LocationInformation locations in result.Locations) {
                    resultList.Append(String.Format("Request Result {0}:\n", resCounter));
                    resultList.Append(String.Format(locations.EntityType + "\n"));
                    resultList.Append(String.Format(locations.Address.FormattedAddress + "\n"));
                    resultList.Append(String.Format("Coordinates: {0}\n", locations.Location));
                    resultList.Append(String.Format("______________________________\n"));
                    resCounter++;
                }
                tbResult.Text = resultList.ToString();
            }

            if (result.Locations.Length == 0)
                tbResult.Text = "The Bing Geocode service does not work for this location.";
        }
        #endregion #CustomRecievedUI

        private void PrepareMap() {
            // Create a map control.
            map = new MapControl();

            // Specify the map position on the form.           
            map.Dock = DockStyle.Fill;

            // Add the map control to the window.
            this.Controls.Add(map);

            // Bring the map to the front.
            map.BringToFront();

            #region #CreateGeocodeProvider
            // Create an image tiles layer and add it to the map.
            ImageTilesLayer tilesLayer = new ImageTilesLayer();
            map.Layers.Add(tilesLayer);

            // Create an  information layer and add it to the map.
            InformationLayer infoLayer = new InformationLayer();
            map.Layers.Add(infoLayer);

            // Create a Bing data provider and specify the Bing key.
            BingMapDataProvider bingProvider = new BingMapDataProvider();
            tilesLayer.DataProvider = bingProvider;
            bingProvider.BingKey = yourBingKey;

            // Create a geocode data provider.
            geocodeProvider = new BingGeocodeDataProvider();
            infoLayer.DataProvider = geocodeProvider;
            geocodeProvider.BingKey = yourBingKey;
            geocodeProvider.MaxVisibleResultCount = 1;
            #endregion #CreateGeocodeProvider

        }

    }

}