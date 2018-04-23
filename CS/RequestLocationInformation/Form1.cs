using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace RequestLocationInformation {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        const string yourBingKey = "Your Bing Key Here";
        const string msgMinMaxErrorFormatString = "The {0} must be less than or equal to {2} and greater than or equal to {1}. Correct the input value.";
        const string latitudeName = "Latitude";
        const double minLatitude = -90;
        const double maxLatitude = 90;
        const string longitudeName = "Longitude";
        const double minLongitude = -180;
        const double maxLongitude = 180;

        BingGeocodeDataProvider geocodeProvider;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            imageProvider.BingKey = yourBingKey;
            #region #CreateGeocodeProvider
            // Create a geocode data provider.
            geocodeProvider = new BingGeocodeDataProvider {
                BingKey = yourBingKey,
                MaxVisibleResultCount = 1
            };
            geocodeProvider.LocationInformationReceived += OnLocationInformationReceived;
            geocodeProvider.LayerItemsGenerating += OnLayerItemsGenerating;
            informationLayer.DataProvider = geocodeProvider;
            #endregion #CreateGeocodeProvider
        }

        #region #CustomRequestUI
        private void requestLocation_Click(object sender, System.EventArgs e) {
            GeoPoint searchPoint;
            if(TryGetLocationArguments(out searchPoint)) {
                geocodeProvider.RequestLocationInformation(searchPoint, 0);
            }
        }

        bool TryGetLocationArguments(out GeoPoint point) {
            double latitude;
            double longitude;
            if (
                TryConvertLocationCoordinate(teLatitude.Text, minLatitude, maxLatitude, latitudeName, out latitude) && 
                TryConvertLocationCoordinate(teLongitude.Text, minLongitude, maxLongitude, longitudeName, out longitude)) {
                point = new GeoPoint(latitude, longitude);
                return true;
            }
            point = null;
            return false;
        }

        bool TryConvertLocationCoordinate(string str, double minValue, double maxValue, string valueName, out double value) {
            double convertedValue = String.IsNullOrEmpty(str)
                ? 0
                : Double.Parse(str);
            if((convertedValue > maxValue) || (convertedValue < minValue)) {
                MessageBox.Show(String.Format(msgMinMaxErrorFormatString, valueName, minValue, maxValue));
                value = 0;
                return false;
            }
            value = convertedValue;
            return true;

        }
        #endregion #CustomRequestUI

        #region #CustomRecievedUI
        private void OnLocationInformationReceived(object sender, LocationInformationReceivedEventArgs e) {
            if(e.Cancelled == true) return;
            if(e.Result.ResultCode != RequestResultCode.Success) {
                meResult.Text = "The Bing Geocode service does not work for this location.";
                return;
            }
            StringBuilder resultList = new StringBuilder("");
            int resCounter = 1;
            foreach(LocationInformation locations in e.Result.Locations) {
                resultList.Append(String.Format("Request Result {0}:\r\n", resCounter));
                resultList.Append(String.Format(locations.EntityType + "\r\n"));
                resultList.Append(String.Format(locations.Address.FormattedAddress + "\r\n"));
                resultList.Append(String.Format("Coordinates: {0}\r\n", locations.Location));
                resultList.Append(String.Format("______________________________\r\n"));
                resCounter++;
            }
            meResult.Text = resultList.ToString();
        }
        #endregion #CustomRecievedUI

        private void OnLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e) {
            mapControl.ZoomToFit(e.Items, 0.4);
        }
    }
}