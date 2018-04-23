' Developer Express Code Central Example:
' How to get information about a geographical point using the Microsoft Bing Geocode web service
' 
' This example demonstrates how to obtain information about a geographical point
' from the Bing Geocode web service.
' 
' To see how it works, do one of the
' following:
' - locate a desired geographical point on a map and click it;
' or
' -
' specify coordinates of a geographical point in Latitude and Longitude text boxes
' and then click the Request Location Information button.
' 
' After that the
' coordinates of the current geographical point are passed to the
' BingGeocodeDataProvider.RequestLocationInformation
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingGeocodeDataProvider_RequestLocationInformationtopic)method.
' Results contain an address (LocationInformation.Address
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Addresstopic)),
' the entity type (LocationInformation.EntityType
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_EntityTypetopic))
' and exact coordinates (LocationInformation.Location
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Locationtopic))
' that are shown in the RichTextBox element. Note that if you run this sample as
' is, you will get a warning message informing you that the specified Bing Maps
' key is invalid. To learn more about the Bing Maps key, please refer to the How
' to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5061

' Developer Express Code Central Example:
' How to get information about a geographical point using the Microsoft Bing Geocode web service
' 
' This example demonstrates how to obtain information about a geographical point
' from the Bing Geocode web service.
' 
' To see how it works, do one of the
' following:
' - locate a desired geographical point on a map and click it;
' or
' -
' specify coordinates of a geographical point in Latitude and Longitude text boxes
' and then click the Request Location Information button.
' 
' After performing one
' of the two approaches, the coordinates of the current geographical point are
' passed to the BingGeocodeDataProvider.RequestLocationInformation
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingGeocodeDataProvider_RequestLocationInformationtopic)
' method. Results contain an address (LocationInformation.Address
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Addresstopic)),
' the entity type (LocationInformation.EntityType
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_EntityTypetopic))
' and exact coordinates (LocationInformation.Location
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Locationtopic))
' that are shown in the RichTextBox element. Note that if you run this sample as
' is, you will get a warning message informing you that the specified Bing Maps
' key is invalid. To learn more about the Bing Maps key, please refer to the How
' to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5061

' Developer Express Code Central Example:
' How to get information about a geographical point using the Microsoft Bing Geocode web service
' 
' This example demonstrates how to obtain information about a geographical point
' from the Bing Geocode web service.
' 
' To see how it works, do one of the
' following:
' - locate a desired geographical point on a map and click it;
' or
' -
' specify coordinates of a geographical point in Latitude and Longitude text boxes
' and then click the Request Location Information button.
' 
' After performing one
' of the two approaches, the coordinates of the current geographical point are
' passed to the BingGeocodeDataProvider.RequestLocationInformation
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingGeocodeDataProvider_RequestLocationInformationtopic)
' method. Results contain an address (LocationInformation.Address
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Addresstopic)),
' the entity type (LocationInformation.EntityType
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_EntityTypetopic))
' and exact coordinates (LocationInformation.Location
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Locationtopic))
' that are shown in the RichTextBox element. Note that if you run this sample as
' is, you will get a warning message informing you that the specified Bing Maps
' key is invalid. To learn more about the Bing Maps key, please refer to the How
' to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5061


Namespace RequestLocationInformation
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.imageLayer = New DevExpress.XtraMap.ImageLayer()
            Me.imageProvider = New DevExpress.XtraMap.BingMapDataProvider()
            Me.informationLayer = New DevExpress.XtraMap.InformationLayer()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.meResult = New DevExpress.XtraEditors.MemoEdit()
            Me.btnGeocode = New DevExpress.XtraEditors.SimpleButton()
            Me.teLongitude = New DevExpress.XtraEditors.TextEdit()
            Me.teLatitude = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciLatitude = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLongitude = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciResult = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciMap = New DevExpress.XtraLayout.LayoutControlItem()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.meResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teLongitude.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teLatitude.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciLatitude, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciLongitude, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciResult, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciMap, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl
            ' 
            Me.mapControl.Layers.Add(Me.imageLayer)
            Me.mapControl.Layers.Add(Me.informationLayer)
            Me.mapControl.Location = New System.Drawing.Point(6, 6)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(401, 316)
            Me.mapControl.TabIndex = 4
            ' 
            ' imageLayer
            ' 
            Me.imageLayer.DataProvider = Me.imageProvider
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.mapControl)
            Me.layoutControl1.Controls.Add(Me.meResult)
            Me.layoutControl1.Controls.Add(Me.btnGeocode)
            Me.layoutControl1.Controls.Add(Me.teLongitude)
            Me.layoutControl1.Controls.Add(Me.teLatitude)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(638, 328)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' meResult
            ' 
            Me.meResult.Location = New System.Drawing.Point(411, 96)
            Me.meResult.Name = "meResult"
            Me.meResult.Size = New System.Drawing.Size(221, 226)
            Me.meResult.StyleController = Me.layoutControl1
            Me.meResult.TabIndex = 7
            ' 
            ' btnGeocode
            ' 
            Me.btnGeocode.Location = New System.Drawing.Point(411, 54)
            Me.btnGeocode.Name = "btnGeocode"
            Me.btnGeocode.Size = New System.Drawing.Size(221, 22)
            Me.btnGeocode.StyleController = Me.layoutControl1
            Me.btnGeocode.TabIndex = 6
            Me.btnGeocode.Text = "Send Geocode Request"
            ' 
            ' teLongitude
            ' 
            Me.teLongitude.Location = New System.Drawing.Point(493, 30)
            Me.teLongitude.Name = "teLongitude"
            Me.teLongitude.Size = New System.Drawing.Size(139, 20)
            Me.teLongitude.StyleController = Me.layoutControl1
            Me.teLongitude.TabIndex = 5
            ' 
            ' teLatitude
            ' 
            Me.teLatitude.Location = New System.Drawing.Point(493, 6)
            Me.teLatitude.Name = "teLatitude"
            Me.teLatitude.Size = New System.Drawing.Size(139, 20)
            Me.teLatitude.StyleController = Me.layoutControl1
            Me.teLatitude.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciLatitude, Me.lciLongitude, Me.layoutControlItem3, Me.lciResult, Me.lciMap})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(638, 328)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciLatitude
            ' 
            Me.lciLatitude.Control = Me.teLatitude
            Me.lciLatitude.Location = New System.Drawing.Point(405, 0)
            Me.lciLatitude.Name = "lciLatitude"
            Me.lciLatitude.Size = New System.Drawing.Size(225, 24)
            Me.lciLatitude.Text = "Latitude:"
            Me.lciLatitude.TextSize = New System.Drawing.Size(79, 13)
            ' 
            ' lciLongitude
            ' 
            Me.lciLongitude.Control = Me.teLongitude
            Me.lciLongitude.Location = New System.Drawing.Point(405, 24)
            Me.lciLongitude.Name = "lciLongitude"
            Me.lciLongitude.Size = New System.Drawing.Size(225, 24)
            Me.lciLongitude.Text = "Longitude:"
            Me.lciLongitude.TextSize = New System.Drawing.Size(79, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.btnGeocode
            Me.layoutControlItem3.Location = New System.Drawing.Point(405, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(225, 26)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' lciResult
            ' 
            Me.lciResult.Control = Me.meResult
            Me.lciResult.Location = New System.Drawing.Point(405, 74)
            Me.lciResult.Name = "lciResult"
            Me.lciResult.Size = New System.Drawing.Size(225, 246)
            Me.lciResult.Text = "Geocode Result:"
            Me.lciResult.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciResult.TextSize = New System.Drawing.Size(79, 13)
            ' 
            ' lciMap
            ' 
            Me.lciMap.Control = Me.mapControl
            Me.lciMap.Location = New System.Drawing.Point(0, 0)
            Me.lciMap.Name = "lciMap"
            Me.lciMap.Size = New System.Drawing.Size(405, 320)
            Me.lciMap.TextSize = New System.Drawing.Size(0, 0)
            Me.lciMap.TextVisible = False
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(638, 328)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Request Location Information Example"
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.meResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teLongitude.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teLatitude.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciLatitude, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciLongitude, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciResult, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciMap, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private mapControl As DevExpress.XtraMap.MapControl
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private meResult As DevExpress.XtraEditors.MemoEdit
        Private WithEvents btnGeocode As DevExpress.XtraEditors.SimpleButton
        Private teLongitude As DevExpress.XtraEditors.TextEdit
        Private teLatitude As DevExpress.XtraEditors.TextEdit
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private lciLatitude As DevExpress.XtraLayout.LayoutControlItem
        Private lciLongitude As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private lciResult As DevExpress.XtraLayout.LayoutControlItem
        Private lciMap As DevExpress.XtraLayout.LayoutControlItem
        Private imageLayer As DevExpress.XtraMap.ImageLayer
        Private imageProvider As DevExpress.XtraMap.BingMapDataProvider
        Private informationLayer As DevExpress.XtraMap.InformationLayer
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

