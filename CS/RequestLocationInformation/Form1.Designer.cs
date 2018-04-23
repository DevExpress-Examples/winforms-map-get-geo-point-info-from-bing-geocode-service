// Developer Express Code Central Example:
// How to get information about a geographical point using the Microsoft Bing Geocode web service
// 
// This example demonstrates how to obtain information about a geographical point
// from the Bing Geocode web service.
// 
// To see how it works, do one of the
// following:
// - locate a desired geographical point on a map and click it;
// or
// -
// specify coordinates of a geographical point in Latitude and Longitude text boxes
// and then click the Request Location Information button.
// 
// After that the
// coordinates of the current geographical point are passed to the
// BingGeocodeDataProvider.RequestLocationInformation
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingGeocodeDataProvider_RequestLocationInformationtopic)method.
// Results contain an address (LocationInformation.Address
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Addresstopic)),
// the entity type (LocationInformation.EntityType
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_EntityTypetopic))
// and exact coordinates (LocationInformation.Location
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Locationtopic))
// that are shown in the RichTextBox element. Note that if you run this sample as
// is, you will get a warning message informing you that the specified Bing Maps
// key is invalid. To learn more about the Bing Maps key, please refer to the How
// to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5061

// Developer Express Code Central Example:
// How to get information about a geographical point using the Microsoft Bing Geocode web service
// 
// This example demonstrates how to obtain information about a geographical point
// from the Bing Geocode web service.
// 
// To see how it works, do one of the
// following:
// - locate a desired geographical point on a map and click it;
// or
// -
// specify coordinates of a geographical point in Latitude and Longitude text boxes
// and then click the Request Location Information button.
// 
// After performing one
// of the two approaches, the coordinates of the current geographical point are
// passed to the BingGeocodeDataProvider.RequestLocationInformation
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingGeocodeDataProvider_RequestLocationInformationtopic)
// method. Results contain an address (LocationInformation.Address
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Addresstopic)),
// the entity type (LocationInformation.EntityType
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_EntityTypetopic))
// and exact coordinates (LocationInformation.Location
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Locationtopic))
// that are shown in the RichTextBox element. Note that if you run this sample as
// is, you will get a warning message informing you that the specified Bing Maps
// key is invalid. To learn more about the Bing Maps key, please refer to the How
// to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5061

// Developer Express Code Central Example:
// How to get information about a geographical point using the Microsoft Bing Geocode web service
// 
// This example demonstrates how to obtain information about a geographical point
// from the Bing Geocode web service.
// 
// To see how it works, do one of the
// following:
// - locate a desired geographical point on a map and click it;
// or
// -
// specify coordinates of a geographical point in Latitude and Longitude text boxes
// and then click the Request Location Information button.
// 
// After performing one
// of the two approaches, the coordinates of the current geographical point are
// passed to the BingGeocodeDataProvider.RequestLocationInformation
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingGeocodeDataProvider_RequestLocationInformationtopic)
// method. Results contain an address (LocationInformation.Address
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Addresstopic)),
// the entity type (LocationInformation.EntityType
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_EntityTypetopic))
// and exact coordinates (LocationInformation.Location
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Locationtopic))
// that are shown in the RichTextBox element. Note that if you run this sample as
// is, you will get a warning message informing you that the specified Bing Maps
// key is invalid. To learn more about the Bing Maps key, please refer to the How
// to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5061


namespace RequestLocationInformation {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.imageLayer = new DevExpress.XtraMap.ImageLayer();
            this.imageProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.informationLayer = new DevExpress.XtraMap.InformationLayer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.meResult = new DevExpress.XtraEditors.MemoEdit();
            this.btnGeocode = new DevExpress.XtraEditors.SimpleButton();
            this.teLongitude = new DevExpress.XtraEditors.TextEdit();
            this.teLatitude = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLatitude = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLongitude = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciResult = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMap = new DevExpress.XtraLayout.LayoutControlItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLongitude.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLatitude.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMap)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            this.mapControl.Layers.Add(this.imageLayer);
            this.mapControl.Layers.Add(this.informationLayer);
            this.mapControl.Location = new System.Drawing.Point(6, 6);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(401, 316);
            this.mapControl.TabIndex = 4;
            // 
            // imageLayer
            // 
            this.imageLayer.DataProvider = this.imageProvider;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.mapControl);
            this.layoutControl1.Controls.Add(this.meResult);
            this.layoutControl1.Controls.Add(this.btnGeocode);
            this.layoutControl1.Controls.Add(this.teLongitude);
            this.layoutControl1.Controls.Add(this.teLatitude);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(638, 328);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // meResult
            // 
            this.meResult.Location = new System.Drawing.Point(411, 96);
            this.meResult.Name = "meResult";
            this.meResult.Size = new System.Drawing.Size(221, 226);
            this.meResult.StyleController = this.layoutControl1;
            this.meResult.TabIndex = 7;
            // 
            // btnGeocode
            // 
            this.btnGeocode.Location = new System.Drawing.Point(411, 54);
            this.btnGeocode.Name = "btnGeocode";
            this.btnGeocode.Size = new System.Drawing.Size(221, 22);
            this.btnGeocode.StyleController = this.layoutControl1;
            this.btnGeocode.TabIndex = 6;
            this.btnGeocode.Text = "Send Geocode Request";
            this.btnGeocode.Click += new System.EventHandler(this.requestLocation_Click);
            // 
            // teLongitude
            // 
            this.teLongitude.Location = new System.Drawing.Point(493, 30);
            this.teLongitude.Name = "teLongitude";
            this.teLongitude.Size = new System.Drawing.Size(139, 20);
            this.teLongitude.StyleController = this.layoutControl1;
            this.teLongitude.TabIndex = 5;
            // 
            // teLatitude
            // 
            this.teLatitude.Location = new System.Drawing.Point(493, 6);
            this.teLatitude.Name = "teLatitude";
            this.teLatitude.Size = new System.Drawing.Size(139, 20);
            this.teLatitude.StyleController = this.layoutControl1;
            this.teLatitude.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLatitude,
            this.lciLongitude,
            this.layoutControlItem3,
            this.lciResult,
            this.lciMap});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(638, 328);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciLatitude
            // 
            this.lciLatitude.Control = this.teLatitude;
            this.lciLatitude.Location = new System.Drawing.Point(405, 0);
            this.lciLatitude.Name = "lciLatitude";
            this.lciLatitude.Size = new System.Drawing.Size(225, 24);
            this.lciLatitude.Text = "Latitude:";
            this.lciLatitude.TextSize = new System.Drawing.Size(79, 13);
            // 
            // lciLongitude
            // 
            this.lciLongitude.Control = this.teLongitude;
            this.lciLongitude.Location = new System.Drawing.Point(405, 24);
            this.lciLongitude.Name = "lciLongitude";
            this.lciLongitude.Size = new System.Drawing.Size(225, 24);
            this.lciLongitude.Text = "Longitude:";
            this.lciLongitude.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnGeocode;
            this.layoutControlItem3.Location = new System.Drawing.Point(405, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(225, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // lciResult
            // 
            this.lciResult.Control = this.meResult;
            this.lciResult.Location = new System.Drawing.Point(405, 74);
            this.lciResult.Name = "lciResult";
            this.lciResult.Size = new System.Drawing.Size(225, 246);
            this.lciResult.Text = "Geocode Result:";
            this.lciResult.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciResult.TextSize = new System.Drawing.Size(79, 13);
            // 
            // lciMap
            // 
            this.lciMap.Control = this.mapControl;
            this.lciMap.Location = new System.Drawing.Point(0, 0);
            this.lciMap.Name = "lciMap";
            this.lciMap.Size = new System.Drawing.Size(405, 320);
            this.lciMap.TextSize = new System.Drawing.Size(0, 0);
            this.lciMap.TextVisible = false;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 328);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Request Location Information Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLongitude.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLatitude.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit meResult;
        private DevExpress.XtraEditors.SimpleButton btnGeocode;
        private DevExpress.XtraEditors.TextEdit teLongitude;
        private DevExpress.XtraEditors.TextEdit teLatitude;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciLatitude;
        private DevExpress.XtraLayout.LayoutControlItem lciLongitude;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem lciResult;
        private DevExpress.XtraLayout.LayoutControlItem lciMap;
        private DevExpress.XtraMap.ImageLayer imageLayer;
        private DevExpress.XtraMap.BingMapDataProvider imageProvider;
        private DevExpress.XtraMap.InformationLayer informationLayer;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

