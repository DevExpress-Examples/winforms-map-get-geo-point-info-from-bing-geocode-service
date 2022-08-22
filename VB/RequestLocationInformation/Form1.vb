Imports System
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap
Imports System.Runtime.InteropServices

Namespace RequestLocationInformation

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Const yourBingKey As String = "Your Bing Key Here"

        Const msgMinMaxErrorFormatString As String = "The {0} must be less than or equal to {2} and greater than or equal to {1}. Correct the input value."

        Const latitudeName As String = "Latitude"

        Const minLatitude As Double = -90

        Const maxLatitude As Double = 90

        Const longitudeName As String = "Longitude"

        Const minLongitude As Double = -180

        Const maxLongitude As Double = 180

        Private geocodeProvider As BingGeocodeDataProvider

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            imageProvider.BingKey = yourBingKey
#Region "#CreateGeocodeProvider"
            ' Create a geocode data provider.
            geocodeProvider = New BingGeocodeDataProvider With {.BingKey = yourBingKey, .MaxVisibleResultCount = 1}
            AddHandler geocodeProvider.LocationInformationReceived, AddressOf OnLocationInformationReceived
            AddHandler geocodeProvider.LayerItemsGenerating, AddressOf OnLayerItemsGenerating
            informationLayer.DataProvider = geocodeProvider
#End Region  ' #CreateGeocodeProvider
        End Sub

#Region "#CustomRequestUI"
        Private Sub requestLocation_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim searchPoint As GeoPoint
            If TryGetLocationArguments(searchPoint) Then
                geocodeProvider.RequestLocationInformation(searchPoint, 0)
            End If
        End Sub

        Private Function TryGetLocationArguments(<Out> ByRef point As GeoPoint) As Boolean
            Dim latitude As Double
            Dim longitude As Double
            If TryConvertLocationCoordinate(teLatitude.Text, minLatitude, maxLatitude, latitudeName, latitude) AndAlso TryConvertLocationCoordinate(teLongitude.Text, minLongitude, maxLongitude, longitudeName, longitude) Then
                point = New GeoPoint(latitude, longitude)
                Return True
            End If

            point = Nothing
            Return False
        End Function

        Private Function TryConvertLocationCoordinate(ByVal str As String, ByVal minValue As Double, ByVal maxValue As Double, ByVal valueName As String, <Out> ByRef value As Double) As Boolean
            Dim convertedValue As Double = If(String.IsNullOrEmpty(str), 0, Double.Parse(str))
            If convertedValue > maxValue OrElse convertedValue < minValue Then
                MessageBox.Show(String.Format(msgMinMaxErrorFormatString, valueName, minValue, maxValue))
                value = 0
                Return False
            End If

            value = convertedValue
            Return True
        End Function

#End Region  ' #CustomRequestUI
#Region "#CustomRecievedUI"
        Private Sub OnLocationInformationReceived(ByVal sender As Object, ByVal e As LocationInformationReceivedEventArgs)
            If e.Cancelled = True Then Return
            If e.Result.ResultCode <> RequestResultCode.Success Then
                meResult.Text = "The Bing Geocode service does not work for this location."
                Return
            End If

            Dim resultList As StringBuilder = New StringBuilder("")
            Dim resCounter As Integer = 1
            For Each locations As LocationInformation In e.Result.Locations
                resultList.Append(String.Format("Request Result {0}:" & Microsoft.VisualBasic.Constants.vbCrLf, resCounter))
                resultList.Append(String.Format(locations.EntityType & Microsoft.VisualBasic.Constants.vbCrLf))
                resultList.Append(String.Format(locations.Address.FormattedAddress & Microsoft.VisualBasic.Constants.vbCrLf))
                resultList.Append(String.Format("Coordinates: {0}" & Microsoft.VisualBasic.Constants.vbCrLf, locations.Location))
                resultList.Append(String.Format("______________________________" & Microsoft.VisualBasic.Constants.vbCrLf))
                resCounter += 1
            Next

            meResult.Text = resultList.ToString()
        End Sub

#End Region  ' #CustomRecievedUI
        Private Sub OnLayerItemsGenerating(ByVal sender As Object, ByVal e As LayerItemsGeneratingEventArgs)
            mapControl.ZoomToFit(e.Items, 0.4)
        End Sub
    End Class
End Namespace
