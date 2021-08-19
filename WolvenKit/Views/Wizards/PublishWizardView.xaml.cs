using System.Windows.Media;
using System.Windows.Media.Imaging;

using HandyControl.Controls;
using ReactiveUI;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models.Wizards;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.Views.Wizards
{
    public partial class PublishWizardView : ReactiveUserControl<PublishWizardViewModel>
    {
        #region Fields

        private FinalizeSetupView FSV;

        private W3PackSettingsView PSV;

        private OptionalSettingsView OSV;

        private RequiredSettingsView RSV;


        #endregion Fields

        #region Constructors

        public PublishWizardView()
        {
            var projectManager = ServiceLocator.Default.ResolveType<IProjectManager>();
            var pwm = ServiceLocator.Default.RegisterTypeAndInstantiate<PublishWizardModel>();

            if (projectManager?.ActiveProject is EditorProject ep)
            {
                var imgPath = System.IO.Path.Combine(ep.ProjectDirectory, "img.png");
                if (System.IO.File.Exists(imgPath))
                {
                    pwm.ProfileImageBrushPath = imgPath;
                    pwm.ProfileImageBrush = new ImageBrush(new BitmapImage(new System.Uri(imgPath)));
                }
            }

            RSV = new RequiredSettingsView();
            OSV = new OptionalSettingsView();
            FSV = new FinalizeSetupView();

            InitializeComponent();

            if (projectManager?.ActiveProject is Tw3Project)
            {
                StepMain.Items.Insert(1, new StepBarItem() { Content = "W3 pack settings" });
                PSV = new W3PackSettingsView();
            }

            ShowPage();
        }

        #endregion Constructors

        #region Methods

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var projectManager = ServiceLocator.Default.ResolveType<IProjectManager>();
            if (StepMain.StepIndex == 0 && RSV.AllProjectFieldIsValid() && RSV.ViewModel is RequiredSettingsViewModel vm)
            {
                projectManager.SaveAsync();
            }

            StepMain.Next();
            ShowPage();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Prev();
            ShowPage();
        }

        private void ShowPage()
        {
            switch (StepMain.StepIndex)
            {
                case 0:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(RSV);
                    break;

                case 1:
                    PageGrid.Children.Clear();
                    if (PSV != null)
                        PageGrid.Children.Add(PSV);
                    else
                        PageGrid.Children.Add(OSV);
                    break;

                case 2:
                    PageGrid.Children.Clear();
                    if (PSV != null)
                        PageGrid.Children.Add(OSV);
                    else
                        PageGrid.Children.Add(FSV);
                    break;

                case 3:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(FSV);
                    break;
            }
        }


        #endregion Methods
    }
}
