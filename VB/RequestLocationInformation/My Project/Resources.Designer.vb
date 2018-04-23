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

' Developer Express Code Central Example:
' How to get information about a geographical point using the MS Bing Geocode data provider
' 
' This example demonstrates how to obtain information about a geographical point
' from the Bing Geocode data provider using the
' BingGeocodeDataProvider.RequestLocationInformation
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingGeocodeDataProvider_RequestLocationInformationtopic)
' method.
' 
' To see how it works, do one of the following:
' - locate a desired
' geographical point on a map and click it;
' or
' - specify coordinates of a
' geographical point in Latitude and Longitude text boxes and then click the
' Request Location Information button.
' 
' After performing one of the two
' approaches, the coordinates of the current geographical point are passed to the
' BingGeocodeDataProvider.RequestLocationInformation method. Results contain an
' address (LocationInformation.Address
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Addresstopic))
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

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My.Resources


    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
    Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

'        internal Resources()
'        {
'        }

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If (resourceMan Is Nothing) Then
                    Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property
    End Module
End Namespace
