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
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors;
/// <summary>
/// Interaction logic for <see cref="LocalizationStringViewModel"/>
/// </summary>
public partial class RedLocalizationStringEditor : UserControl
{
    private readonly IProjectManager _projectManager;
    private readonly Cr2WTools _cr2wTools;
    private readonly AppViewModel _appViewModel;
    private readonly ProjectResourceTools _projectResourceTools;

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

        _projectManager = Locator.Current.GetService<IProjectManager>();
        _cr2wTools = Locator.Current.GetService<Cr2WTools>();
        _projectResourceTools = Locator.Current.GetService<ProjectResourceTools>();
        _appViewModel = Locator.Current.GetService<App.ViewModels.Shell.AppViewModel>();
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
        if (Interactions.ShowGenerateTranslationEntry(_projectManager.ActiveProject) is not { IsValid: true } vm)
        {
            return;
        }

        var locString = new LocalizationString { Unk1 = 0, Value = "" };

        // If successfully saved to i18n file, update the LocalizationString to point at the new entry
        if (SaveToLocalizationFile(vm.FemaleVariant, vm.MaleVariant, vm.SecondaryKey))
        {
            locString = new LocalizationString { Unk1 = RedLocalizationString.Unk1, Value = vm.SecondaryKey };
        }

        // Set property - this notifies the CVM
        SetCurrentValue(RedLocalizationStringProperty, locString);

        if (DataContext is not ChunkViewModel cvm)
        {
            return;
        }

        cvm.RecalculateProperties();
        cvm.Parent?.RecalculateProperties();
    }

    private bool SaveToLocalizationFile(string femaleVariant, string maleVariant, string secondaryKey)
    {
        if (_projectManager?.ActiveProject is not { } project || _cr2wTools is null)
        {
            return false;
        }

        try
        {
            CR2WFile cr2W = null;
            localizationPersistenceOnScreenEntries entries = null;

            var onscreensRelativePath = project.ModFiles.Where(f => f.HasFileExtension(".json"))
                .FirstOrDefault(f =>
                {
                    if (_cr2wTools.ReadCr2W(Path.Join(project.ModDirectory, f)) is not
                        {
                            RootChunk: JsonResource
                            {
                                Root.Chunk: localizationPersistenceOnScreenEntries existing
                            }
                        } fileContent)
                    {
                        return false;
                    }

                    cr2W = fileContent;
                    entries = existing;
                    return true;
                });


            var onscreenAbsolutePath = Path.Join(project.ModDirectory, onscreensRelativePath);
            if (string.IsNullOrEmpty(onscreensRelativePath) || !File.Exists(onscreenAbsolutePath))
            {
                Interactions.ShowErrorPopup((
                    $"Your mod does not contain an onscreen.json, or is not properly initialised.",
                    "Error"));
                return false;
            }

            // Save file if it's dirty
            if (!_appViewModel.SaveIfDirty(onscreensRelativePath))
            {
                Interactions.ShowErrorPopup((
                    $"Your onscreen.json could not be autosaved and has unsaved changes.",
                    "Error"));
                return false;
            }


            // Check if entry with this secondaryKey already exists
            if (entries.Entries.FirstOrDefault(e => e.SecondaryKey == secondaryKey) is { } existingEntry)
            {
                if (!Interactions.ShowQuestionYesNo((
                        $"Entry {existingEntry} already exists. Overwrite it?", "Overwrite Entry?")))
                {
                    return false;
                }

                existingEntry.FemaleVariant = femaleVariant;
                existingEntry.MaleVariant = maleVariant;
            }
            else
            {
                // Add new entry
                var newEntry = new localizationPersistenceOnScreenEntry
                {
                    SecondaryKey = secondaryKey, FemaleVariant = femaleVariant, MaleVariant = maleVariant
                };
                entries.Entries.Add(newEntry);
            }

            // Save the file
            _cr2wTools.WriteCr2W(cr2W, onscreenAbsolutePath);
            _appViewModel.ReloadIfOpen(onscreensRelativePath);

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to save localization data: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }
    }


}
