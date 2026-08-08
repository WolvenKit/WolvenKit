using System.Windows.Input;
using ReactiveUI;
using System.Windows;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.Views.Dialogs.Windows;
/// <summary>
/// Interaction logic for ConvertToCCXLMaterials.xaml
/// </summary>
public partial class CreateCCXLHairDialog : IViewFor<CreateCCXLHairDialogViewModel>
{
    public CreateCCXLHairDialog(Cp77Project activeProject)
    {
        InitializeComponent();
        ViewModel = new CreateCCXLHairDialog(activeProject);
        DataContext = ViewModel;
    }

    public CreateCCXLHairDialog ViewModel { get; set; }
    object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (CreateCCXLHairDialog)value; }

    private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Enter)
        {
            return;
        }

        e.Handled = true;
        DialogResult = true;
        Close();
    }

    private void WizardControl_OnFinish(object sender, RoutedEventArgs e) { }
}

 //   private async void OnAPPTest(object _, RoutedEventArgs e)
 //   {
 //       // in .app or root entity: warn with >5 appearances, because this can take a while
 //       if (ViewModel?.RootChunk is not ChunkViewModel cvm || cvm.ResolvedData is not appearanceAppearanceResource app ||
 //_projectManager.ActiveProject is not Cp77Project activeProject)
 //       {

 //           return;
 //       }

 //       var i = 0;
 //       var comp = app.Appearances.First().Chunk!;

 //       cvm.GetPropertyChild("appearances")?.CalculateProperties();

 //       ((entSkinnedMeshComponent)comp.Components[i]).Name = "Test_shadow";

 //       ((entSkinnedMeshComponent)comp.Components[i++]).Mesh = new CResourceAsyncReference<CMesh>($"file\\test\\.mesh");


 //       ((entAnimatedComponent)comp.Components[i]).Graph = new CResourceReference<animAnimGraph>($"file\\test\\.animgraph");
 //       ((entAnimatedComponent)comp.Components[i++]).Rig = new CResourceReference<animRig>($"file\\test\\.rig");


 //       ((entSkinnedMeshComponent)comp.Components[i]).Name = "Test";

 //       ((entSkinnedMeshComponent)comp.Components[i]).Mesh = new CResourceAsyncReference<CMesh>($"file\\test\\.mesh");


 //       comp.ResolvedDependencies[3] = new CResourceAsyncReference<CResource>("ccxl\\xl\\file.mesh");
 //       comp.ResolvedDependencies[4] = new CResourceAsyncReference<CResource>("ccxl\\xl\\file_shadow.mesh");


 //       cvm.GetPropertyChild("appearances")?.RecalculateProperties();
 //       cvm.Tab?.Parent.SetIsDirty(true);
 //   }

 //   private async void OnJSONTest(object _, RoutedEventArgs e)
 //   {
 //       if (ViewModel?.RootChunk is not ChunkViewModel cvm || cvm.ResolvedData is not JsonResource json ||
 //_projectManager.ActiveProject is not Cp77Project activeProject)
 //       {

 //           return;
 //       }
 //       var x = json.Root.Chunk!;


 //       cvm.Tab?.Parent.SetIsDirty(true);

 //   }


