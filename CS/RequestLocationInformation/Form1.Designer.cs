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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.requestLocation = new System.Windows.Forms.Button();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.requestLocation);
            this.panelControl1.Controls.Add(this.tbLongitude);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.tbLatitude);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(380, 155);
            this.panelControl1.TabIndex = 1;
            // 
            // requestLocation
            // 
            this.requestLocation.Location = new System.Drawing.Point(87, 107);
            this.requestLocation.Name = "requestLocation";
            this.requestLocation.Size = new System.Drawing.Size(205, 23);
            this.requestLocation.TabIndex = 5;
            this.requestLocation.Text = "Request Location Information";
            this.requestLocation.UseVisualStyleBackColor = true;
            this.requestLocation.Click += new System.EventHandler(this.requestLocation_Click);
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(97, 60);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(100, 20);
            this.tbLongitude.TabIndex = 3;
            this.tbLongitude.Text = "-120";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitude:";
            // 
            // tbLatitude
            // 
            this.tbLatitude.Location = new System.Drawing.Point(97, 10);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(100, 20);
            this.tbLatitude.TabIndex = 1;
            this.tbLatitude.Text = "40";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbResult
            // 
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.Location = new System.Drawing.Point(2, 157);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(380, 316);
            this.tbResult.TabIndex = 0;
            this.tbResult.Text = "";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.tbResult);
            this.panelControl3.Controls.Add(this.panelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(551, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(384, 475);
            this.panelControl3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 475);
            this.Controls.Add(this.panelControl3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button requestLocation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox tbResult;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}

