using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Templates;

namespace WolvenKit.Views.Editors;
/// <summary>
/// Interaktionslogik für RedLocalizationStringEditor.xaml
/// </summary>
public partial class RedLocalizationStringEditor : UserControl
{
    public LocalizationString RedLocalizationString
    {
        get => (LocalizationString)GetValue(RedLocalizationStringProperty);
        set => SetValue(RedLocalizationStringProperty, value);
    }
    public static readonly DependencyProperty RedLocalizationStringProperty = DependencyProperty.Register(
        nameof(RedLocalizationString), typeof(LocalizationString), typeof(RedLocalizationStringEditor));

    public RedLocalizationStringEditor()
    {
        InitializeComponent();
    }

    public string Unk1
    {
        get => RedLocalizationString.Unk1.ToString();
        set
        {
            var ulongValue = ulong.Parse(value);
            if (RedLocalizationString.Unk1 != ulongValue)
            {
                // Set the whole LocalizationString instead of Unk1, so the CVM gets notified
                SetValue(RedLocalizationStringProperty, new LocalizationString
                {
                    Unk1 = ulongValue,
                    Value = RedLocalizationString.Value
                });
            }
        }
    }

    public string Value
    {
        get => RedLocalizationString.Value;
        set
        {
            if (RedLocalizationString.Value != value)
            {
                // Set the whole LocalizationString instead of Value, so the CVM gets notified
                SetValue(RedLocalizationStringProperty, new LocalizationString
                {
                    Unk1 = RedLocalizationString.Unk1,
                    Value = value
                });
            }
        }
    }

    private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
    {
        if (e.Source is not TextBox textBox)
        {
            throw new Exception();
        }

        e.Handled = !ulong.TryParse(textBox.Text.Insert(textBox.CaretIndex, e.Text), out _);
    }

    private void EditButton_Click(object sender, RoutedEventArgs e)
    {
        var popup = new LocalizationStringPopup();
        var result = popup.ShowDialog();

        if (result == true)
        {
            // Get the values from the popup
            var femaleVariant = popup.FemaleVariant;
            var maleVariant = popup.MaleVariant;
            var secondaryKey = popup.SecondaryKey;

            // Update the LocalizationString Value with the secondaryKey
            if (!string.IsNullOrEmpty(secondaryKey))
            {
                // Save to the onscreens localization file first
                var fileExists = SaveToLocalizationFile(femaleVariant, maleVariant, secondaryKey);

                if (fileExists)
                {
                    // Update the LocalizationString - this notifies the CVM
                    SetCurrentValue(RedLocalizationStringProperty, new LocalizationString
                    {
                        Unk1 = RedLocalizationString.Unk1,
                        Value = secondaryKey
                    });
                }
                else
                {
                    // Update the LocalizationString - this notifies the CVM
                    SetCurrentValue(RedLocalizationStringProperty, new LocalizationString
                    {
                        Unk1 = 0,
                        Value = ""
                    });
                }

                if (DataContext is not ChunkViewModel cvm)
                {
                    return;
                }
                cvm.RecalculateProperties();
                cvm.Parent?.RecalculateProperties();
            }
        }
    }

    private bool SaveToLocalizationFile(string femaleVariant, string maleVariant, string secondaryKey)
    {
        try
        {
            var projectManager = Locator.Current.GetService<IProjectManager>();
            var cr2wTools = Locator.Current.GetService<Cr2WTools>();

            if (projectManager?.ActiveProject == null || cr2wTools == null)
            {
                return false;
            }

            var modDir = Path.Combine(projectManager.ActiveProject.ModDirectory, "mod", projectManager.ActiveProject.Name);

            // Search for existing onscreens files in the entire mod directory
            string onscreensPath = null;

            // search for json recursively in the mod directory
            if (Directory.Exists(modDir))
            {
                var allJsonFiles = Directory.GetFiles(modDir, "*.json", SearchOption.AllDirectories);
                foreach (var file in allJsonFiles)
                {
                    try
                    {
                        var testCr2w = cr2wTools.ReadCr2W(file);
                        if (testCr2w?.RootChunk is JsonResource json &&
                            json.Root.Chunk is localizationPersistenceOnScreenEntries)
                        {
                            onscreensPath = file;
                            break;
                        }

                        MessageBox.Show(
                            $"Onscreen json doesn't exist in {Path.GetFileName(modDir)} or is not properly initialised.",
                            "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                    catch
                    {
                        // ignore
                    }
                }

                // Reload the file if it's currently open
                ReloadFileIfOpen(onscreensPath);

                localizationPersistenceOnScreenEntries entries = null;

                if (!File.Exists(onscreensPath))
                {
                    MessageBox.Show(
                        $"Onscreen json doesn't exist in {Path.GetFileName(modDir)} or is not properly initialised.",
                        "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }

                var cr2w = cr2wTools.ReadCr2W(onscreensPath);

                if (cr2w?.RootChunk is JsonResource jsonResource && jsonResource.Root.Chunk is localizationPersistenceOnScreenEntries existing)
                {
                    entries = existing;
                }
                else
                {
                    entries = new localizationPersistenceOnScreenEntries();
                    cr2w = new CR2WFile { RootChunk = new JsonResource { Root = new CHandle<ISerializable>(entries) } };
                }

                // Check if entry with this secondaryKey already exists
                if (entries.Entries.FirstOrDefault(e => e.SecondaryKey == secondaryKey) is { } existingEntry)
                {
                    if (Interactions.ShowQuestionYesNo((
                            $"Entry {existingEntry} already exists. Overwrite it?", "Overwrite Entry?")))
                    {
                        existingEntry.FemaleVariant = femaleVariant;
                        existingEntry.MaleVariant = maleVariant;
                    }
                }
                else
                {
                    // Add new entry
                    var newEntry = new localizationPersistenceOnScreenEntry
                    {
                        SecondaryKey = secondaryKey,
                        FemaleVariant = femaleVariant,
                        MaleVariant = maleVariant
                    };
                    entries.Entries.Add(newEntry);
                }

                // Save the file
                cr2wTools.WriteCr2W(cr2w, onscreensPath);
                ReloadFileIfOpen(onscreensPath);
            }

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to save localization data: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }
    }

    private static void ReloadFileIfOpen(string filePath)
    {
        try
        {
            if (Locator.Current.GetService<App.ViewModels.Shell.AppViewModel>() is not {} appViewModel)
            {
                return;
            }

            // Find the document with this file path
            var openDocument = appViewModel.DockedViews
                .OfType<App.ViewModels.Documents.IDocumentViewModel>()
                .FirstOrDefault(doc => doc.FilePath != null &&
                                      Path.GetFullPath(doc.FilePath).Equals(Path.GetFullPath(filePath), StringComparison.OrdinalIgnoreCase));

            if (openDocument == null)
            {
                return;
            }

            if (openDocument.IsDirty)
            {
                appViewModel.SaveFile(filePath);
            }

            openDocument.Reload(true);
        }
        catch
        {
            // Silently fail if reload doesn't work
        }
    }
}
