<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128621464/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3576)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))**
* [SplashScreen1.cs](./CS/SplashScreen1.cs) (VB: [SplashScreen1.vb](./VB/SplashScreen1.vb))
<!-- default file list end -->
# How to interact with a Splash Screen by sending commands


<p>In this example a custom Progress Bar Control is added to a Splash Screen. The example shows how to update this Progress Bar Control dynamically by sending commands from a Splash Screen Manager.</p><p>Splash Screens are displayed by a Splash Screen Manager in a separate thread. Interaction with Splash Screens can be performed via the command mechanism. You send a command via the SplashScreenManager.SendCommand method and process this command by overriding the SplashScreen.ProcessCommand method.</p><br />
<p>In the example, custom commands are sent to the Splash Screen to advance the progress of the Splash Screen's Progress Bar Control.</p><br />


<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-splash-screen-send-commands&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-splash-screen-send-commands&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
