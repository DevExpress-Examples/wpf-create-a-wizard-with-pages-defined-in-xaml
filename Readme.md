<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128657964/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T415416)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Create a Wizard with Pages Defined in XAML

This example demonstrates how to create a simple [Wizard](https://docs.devexpress.com/WPF/115979/controls-and-libraries/navigation-controls/wizard-control) with predefined pages. 

![image](https://user-images.githubusercontent.com/12169834/183713886-d68f2837-5020-41d6-9498-5b0d6a90cd1f.png)

Wizard control includes the following built-in [page](https://docs.devexpress.com/WPF/115997/controls-and-libraries/navigation-controls/wizard-control/pages) types: 

* **WelcomeWizardPage** 
* **WizardPage** 
* **CompletionWizardPage**  

These pages have the same functionality, and only their button and content region visibility settings are different. To show/hide [page buttons](https://docs.devexpress.com/WPF/115998/controls-and-libraries/navigation-controls/wizard-control/buttons), use the following properties:  

- [ShowBack](https://docs.devexpress.com/WPF/DevExpress.Xpf.Controls.WizardPage.ShowBack)
- [ShowCancel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Controls.WizardPage.ShowCancel)
- [ShowFinish](https://docs.devexpress.com/WPF/DevExpress.Xpf.Controls.WizardPage.ShowFinish)
- [ShowNext](https://docs.devexpress.com/WPF/DevExpress.Xpf.Controls.WizardPage.ShowNext)
  
<!-- default file list -->
## Files to Look At

* **[MainWindow.xaml](./CS/WizardControlExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WizardControlExample/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/WizardControlExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WizardControlExample/MainWindow.xaml.vb))
<!-- default file list end -->

## Documentation

* [Wizard Control](https://docs.devexpress.com/WPF/115979/controls-and-libraries/navigation-controls/wizard-control)
* [Wizard Pages](https://docs.devexpress.com/WPF/115997/controls-and-libraries/navigation-controls/wizard-control/pages)
* [Wizard Buttons](https://docs.devexpress.com/WPF/115998/controls-and-libraries/navigation-controls/wizard-control/buttons)

## More Examples
* [How to: Create a wizard based on a collection of view models](https://github.com/DevExpress-Examples/how-to-create-a-wizard-based-on-a-collection-of-view-models-t415475)  
* [How to: Use the WizardService](https://github.com/DevExpress-Examples/how-to-use-the-wizardservice-t387258)
