Imports System
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace RequestLocationInformation

    Public Partial Class Form1
        Inherits Form

        Private latitude As Double

        Private longitude As Double

        Const yourBingKey As String = "INSERT_YOUR_BING_KEY_HERE"

        Private geocodeProvider As BingGeocodeDataProvider

        Private map As MapControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            PrepareMap()
            AddHandler geocodeProvider.LocationInformationReceived, New LocationInformationReceivedEventHandler(AddressOf geocodeProvider_LocationInformationReceived)
        End Sub

#Region "#CustomRequestUI"
        Private Sub requestLocation_Click(ByVal sender As Object, ByVal e As EventArgs)
            If GetLocationArguments() Then
                geocodeProvider.RequestLocationInformation(New GeoPoint(latitude, longitude), 0)
            End If
        End Sub

        Private Function GetLocationArguments() As Boolean
            latitude = If(String.IsNullOrEmpty(tbLatitude.Text), 0, Double.Parse(tbLatitude.Text))
            If latitude > 90 OrElse latitude < -90 Then
                MessageBox.Show("Latitude must be less than or equal to 90 and greater than or equal to - 90. Correct the input value.")
                Return False
            End If

            longitude = If(String.IsNullOrEmpty(tbLongitude.Text), 0, Double.Parse(tbLongitude.Text))
            If longitude > 180 OrElse longitude < -180 Then
                MessageBox.Show("Longitude must be less than or equal to 180 and greater than or equal to - 180. Correct the input value.")
                Return False
            End If

            Return True
        End Function

#End Region  ' #CustomRequestUI
#Region "#CustomRecievedUI"
        Private Sub geocodeProvider_LocationInformationReceived(ByVal sender As Object, ByVal e As LocationInformationReceivedEventArgs)
            Dim result As GeocodeRequestResult = e.Result
            If result.Locations.Length > 0 Then
                NavigateTo(result.Locations(0).Location)
            End If

            DisplayResult(result)
        End Sub

        Private Sub NavigateTo(ByVal geoPoint As GeoPoint)
            map.CenterPoint = geoPoint
            map.ZoomLevel = 7
        End Sub

        Private Sub DisplayResult(ByVal result As GeocodeRequestResult)
            Dim resultList As StringBuilder = New StringBuilder("")
            Dim resCounter As Integer = 1
            If result.ResultCode = RequestResultCode.Success Then
                For Each locations As LocationInformation In result.Locations
                    resultList.Append(String.Format("Request Result {0}:" & Microsoft.VisualBasic.Constants.vbLf, resCounter))
                    resultList.Append(String.Format(locations.EntityType & Microsoft.VisualBasic.Constants.vbLf))
                    resultList.Append(String.Format(locations.Address.FormattedAddress & Microsoft.VisualBasic.Constants.vbLf))
                    resultList.Append(String.Format("Coordinates: {0}" & Microsoft.VisualBasic.Constants.vbLf, locations.Location))
                    resultList.Append(String.Format("______________________________" & Microsoft.VisualBasic.Constants.vbLf))
                    resCounter += 1
                Next

                tbResult.Text = resultList.ToString()
            End If

            If result.Locations.Length = 0 Then tbResult.Text = "The Bing Geocode service does not work for this location."
        End Sub

#End Region  ' #CustomRecievedUI
        Private Sub PrepareMap()
            ' Create a map control.
            map = New MapControl()
            ' Specify the map position on the form.           
            map.Dock = DockStyle.Fill
            ' Add the map control to the window.
            Me.Controls.Add(map)
            ' Bring the map to the front.
            map.BringToFront()
#Region "#CreateGeocodeProvider"
            ' Create an image tiles layer and add it to the map.
            Dim tilesLayer As ImageTilesLayer = New ImageTilesLayer()
            map.Layers.Add(tilesLayer)
            ' Create an  information layer and add it to the map.
            Dim infoLayer As InformationLayer = New InformationLayer()
            map.Layers.Add(infoLayer)
            ' Create a Bing data provider and specify the Bing key.
            Dim bingProvider As BingMapDataProvider = New BingMapDataProvider()
            tilesLayer.DataProvider = bingProvider
            bingProvider.BingKey = yourBingKey
            ' Create a geocode data provider.
            geocodeProvider = New BingGeocodeDataProvider()
            infoLayer.DataProvider = geocodeProvider
            geocodeProvider.BingKey = yourBingKey
            geocodeProvider.MaxVisibleResultCount = 1
#End Region  ' #CreateGeocodeProvider
        End Sub
    End Class
End Namespace
