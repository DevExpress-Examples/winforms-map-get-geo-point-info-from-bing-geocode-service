<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576471/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5061)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/RequestLocationInformation/Form1.cs) (VB: [Form1.vb](./VB/RequestLocationInformation/Form1.vb))**
<!-- default file list end -->
# How to get information about a geographical point using the Microsoft Bing Geocode web service


<p>This example demonstrates how to obtain information about a geographical point from the Bing Geocode web service.</p><p>To see how it works, do one of the following:<br />
- locate a desired geographical point on a map and click it;<br />
or<br />
- specify coordinates of a geographical point in <strong>Latitude </strong>and <strong>Longitude</strong> text boxes and then click the <strong>Request Location Information</strong> button.</p><p>After that  the coordinates of the current geographical point are passed to the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingGeocodeDataProvider_RequestLocationInformationtopic"><u>BingGeocodeDataProvider.RequestLocationInformation </u></a>method. Results contain an address (<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Addresstopic"><u>LocationInformation.Address</u></a>), the entity type (<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_EntityTypetopic"><u>LocationInformation.EntityType</u></a>) and exact coordinates (<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLocationInformation_Locationtopic"><u>LocationInformation.Location</u></a><u>)</u> that are shown in the<strong> RichTextBox</strong> element. </p><p><br />
Note that if you run this sample as is, you will get a warning message informing you that the specified Bing Maps key is invalid. To learn more about the Bing Maps key, please refer to the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument15102"><u>How to: Get a Bing Maps Key</u></a> tutorial.</p>

<br/>


