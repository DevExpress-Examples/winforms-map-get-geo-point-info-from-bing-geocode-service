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

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.requestLocation = New System.Windows.Forms.Button()
            Me.tbLongitude = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.tbLatitude = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tbResult = New System.Windows.Forms.RichTextBox()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.requestLocation)
            Me.panelControl1.Controls.Add(Me.tbLongitude)
            Me.panelControl1.Controls.Add(Me.label2)
            Me.panelControl1.Controls.Add(Me.tbLatitude)
            Me.panelControl1.Controls.Add(Me.label1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(2, 2)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(380, 155)
            Me.panelControl1.TabIndex = 1
            ' 
            ' requestLocation
            ' 
            Me.requestLocation.Location = New System.Drawing.Point(87, 107)
            Me.requestLocation.Name = "requestLocation"
            Me.requestLocation.Size = New System.Drawing.Size(205, 23)
            Me.requestLocation.TabIndex = 5
            Me.requestLocation.Text = "Request Location Information"
            Me.requestLocation.UseVisualStyleBackColor = True
            AddHandler Me.requestLocation.Click, New System.EventHandler(AddressOf Me.requestLocation_Click)
            ' 
            ' tbLongitude
            ' 
            Me.tbLongitude.Location = New System.Drawing.Point(97, 60)
            Me.tbLongitude.Name = "tbLongitude"
            Me.tbLongitude.Size = New System.Drawing.Size(100, 20)
            Me.tbLongitude.TabIndex = 3
            Me.tbLongitude.Text = "-120"
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(25, 63)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(57, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Longitude:"
            ' 
            ' tbLatitude
            ' 
            Me.tbLatitude.Location = New System.Drawing.Point(97, 10)
            Me.tbLatitude.Name = "tbLatitude"
            Me.tbLatitude.Size = New System.Drawing.Size(100, 20)
            Me.tbLatitude.TabIndex = 1
            Me.tbLatitude.Text = "40"
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(25, 13)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(48, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Latitude:"
            ' 
            ' contextMenuStrip1
            ' 
            Me.contextMenuStrip1.Name = "contextMenuStrip1"
            Me.contextMenuStrip1.Size = New System.Drawing.Size(61, 4)
            ' 
            ' tbResult
            ' 
            Me.tbResult.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbResult.Location = New System.Drawing.Point(2, 157)
            Me.tbResult.Name = "tbResult"
            Me.tbResult.[ReadOnly] = True
            Me.tbResult.Size = New System.Drawing.Size(380, 316)
            Me.tbResult.TabIndex = 0
            Me.tbResult.Text = ""
            ' 
            ' panelControl3
            ' 
            Me.panelControl3.Controls.Add(Me.tbResult)
            Me.panelControl3.Controls.Add(Me.panelControl1)
            Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelControl3.Location = New System.Drawing.Point(551, 0)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(384, 475)
            Me.panelControl3.TabIndex = 3
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(935, 475)
            Me.Controls.Add(Me.panelControl3)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private tbLongitude As System.Windows.Forms.TextBox

        Private label2 As System.Windows.Forms.Label

        Private tbLatitude As System.Windows.Forms.TextBox

        Private label1 As System.Windows.Forms.Label

        Private requestLocation As System.Windows.Forms.Button

        Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip

        Private tbResult As System.Windows.Forms.RichTextBox

        Private panelControl3 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
