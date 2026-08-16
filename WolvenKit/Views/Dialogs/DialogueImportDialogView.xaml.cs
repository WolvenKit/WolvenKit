#nullable enable
using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Win32;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction.Options;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs;

/// <summary>
/// Takes a dialogue export written by another tool - the Dialogue Browser CET mod writes one from
/// its conversation panel - and lets the user pick which of its lines go into the scene.
/// </summary>
public partial class DialogueImportDialogView : Window
{
    public DialogueImportDialogViewModel ViewModel { get; set; }

    public DialogueImportDialogView(DialogueImportDialogOptions dialogOptions)
    {
        ViewModel = new DialogueImportDialogViewModel(dialogOptions);
        DataContext = ViewModel;
        InitializeComponent();

        LoadClipboardIfItLooksLikeAnExport();
    }

    /// <summary>
    /// The export puts itself on the clipboard, so in the common case the lines are already listed
    /// when the dialog comes up. Only a payload that announces itself is taken: a user who has
    /// something else entirely copied should not be met with a parse error.
    /// </summary>
    private void LoadClipboardIfItLooksLikeAnExport()
    {
        try
        {
            if (!Clipboard.ContainsText())
            {
                return;
            }

            var text = Clipboard.GetText();

            if (DialogueImportHelper.LooksLikePayload(text))
            {
                ViewModel.SetPayload(text, "the clipboard");
            }
        }
        catch (Exception)
        {
            // A clipboard another process has locked is not worth reporting: the user still has
            // the paste button and the file picker.
        }
    }

    private void OnLoadFileClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFileDialog
        {
            Title = "Select a dialogue export",
            Multiselect = false,
            Filter = "Dialogue export (*.json)|*.json|All files (*.*)|*.*"
        };

        // The exports are all in one place, so the picker opens there rather than wherever the last
        // unrelated file was opened from.
        var exportDirectory = GetDialogueBrowserExportDirectory();

        if (exportDirectory is not null)
        {
            dialog.InitialDirectory = exportDirectory;
        }

        if (dialog.ShowDialog(this) != true || string.IsNullOrEmpty(dialog.FileName))
        {
            return;
        }

        ViewModel.LoadFile(dialog.FileName);
    }

    /// <summary>
    /// The Dialogue Browser's export folder in the game install, when there is one to point at.
    /// Null when the game path is unset or the mod has never written there: a folder that does not
    /// exist is worse to open on than wherever the picker was last.
    /// </summary>
    private static string? GetDialogueBrowserExportDirectory()
    {
        try
        {
            if (Locator.Current.GetService<ISettingsManager>() is not { } settingsManager)
            {
                return null;
            }

            var directory = DialogueImportHelper.GetExportDirectory(settingsManager.GetRED4GameRootDir());

            return Directory.Exists(directory) ? directory : null;
        }
        catch (Exception)
        {
            // No game executable set, or one pointing somewhere that is no longer there.
            return null;
        }
    }

    /// <summary>Opens the mod's page in whatever the user browses with.</summary>
    private void OnHyperlinkRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        try
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
        }
        catch (Exception)
        {
            // No browser to hand it to. The url is on screen either way.
        }

        e.Handled = true;
    }

    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }
}
