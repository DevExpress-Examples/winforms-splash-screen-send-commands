<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128621464/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3576)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [SplashScreen1.cs](./CS/SplashScreen1.cs) (VB: [SplashScreen1.vb](./VB/SplashScreen1.vb))
<!-- default file list end -->
# How to interact with a Splash Screen by sending commands

In this example a custom Progress Bar Control is added to a Splash Screen. The example shows how to update this Progress Bar Control dynamically by sending commands from a Splash Screen Manager.

Splash Screens are displayed by a Splash Screen Manager in a separate thread. Interaction with Splash Screens can be performed via the command mechanism. You send a command via the SplashScreenManager.SendCommand method and process this command by overriding the SplashScreen.ProcessCommand method.

In the example, custom commands are sent to the Splash Screen to advance the progress of the Splash Screen's Progress Bar Control.

## Documentation

* [Splash Screen Manager](https://docs.devexpress.com/WindowsForms/10826/controls-and-libraries/forms-and-user-controls/splash-screen-manager)
* [Fluent Splash Screen](https://docs.devexpress.com/WindowsForms/401719/controls-and-libraries/forms-and-user-controls/splash-screen-manager/fluent-splash-screen)
* [Overlay Form](https://docs.devexpress.com/WindowsForms/120029/controls-and-libraries/forms-and-user-controls/splash-screen-manager/overlay-form)





