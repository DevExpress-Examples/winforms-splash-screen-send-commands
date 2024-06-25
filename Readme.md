<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128621464/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3576)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Splash Screen Manager - Interact with the Splash Screen by sending commands

This example adds a Progress Bar control to a Splash Screen and updates it dynamically by sending commands from the Splash Screen Manager.

The Splash Screen Manager displays Splash Screens in a separate thread. The Splash Screen Manager implements the command mechanism that allows you to interact with Splash Screens. Use the `SplashScreenManager.SendCommand` method to send and process commands (by overriding the `SplashScreen.ProcessCommand` method).

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [SplashScreen1.cs](./CS/SplashScreen1.cs) (VB: [SplashScreen1.vb](./VB/SplashScreen1.vb))

## Documentation

* [Splash Screen Manager](https://docs.devexpress.com/WindowsForms/10826/controls-and-libraries/forms-and-user-controls/splash-screen-manager)
* [Fluent Splash Screen](https://docs.devexpress.com/WindowsForms/401719/controls-and-libraries/forms-and-user-controls/splash-screen-manager/fluent-splash-screen)
* [Overlay Form](https://docs.devexpress.com/WindowsForms/120029/controls-and-libraries/forms-and-user-controls/splash-screen-manager/overlay-form)
* [Wait Form](https://docs.devexpress.com/WindowsForms/10824/controls-and-libraries/forms-and-user-controls/splash-screen-manager/wait-form)





<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-splash-screen-send-commands&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-splash-screen-send-commands&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
