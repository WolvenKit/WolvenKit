using System;
using System.Diagnostics;
using System.Windows;
using Microsoft.Win32;
using Splat;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services.Themes;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit.Helpers
{
    /// <summary>
    /// Theme actions shared by the settings page and the main menu.
    /// </summary>
    public static class ThemeUiHelper
    {
        public static IThemeService ThemeService => Locator.Current.GetService<IThemeService>();

        private static Window DefaultOwner => Application.Current?.MainWindow;

        /// <summary>
        /// Opens the theme editor. For a built-in theme the editor creates a new theme based on it.
        /// </summary>
        public static void OpenEditor(ThemeDto theme, Window owner = null)
        {
            theme ??= ThemeService.Current;
            var window = new ThemeEditorWindow(ThemeService, theme) { Owner = owner ?? DefaultOwner };
            window.ShowDialog();
        }

        public static void Duplicate(ThemeDto theme, Window owner = null)
        {
            try
            {
                var copy = ThemeService.Duplicate(theme, $"{theme.Name} (copy)");
                OpenEditor(copy, owner);
            }
            catch (Exception ex)
            {
                ShowError("Could not duplicate theme", ex);
            }
        }

        public static void Delete(ThemeDto theme)
        {
            if (theme is null || theme.IsBuiltIn)
            {
                return;
            }

            var result = Interactions.ShowMessageBox(
                $"Delete theme \"{theme.Name}\"?\n\nThemes based on it keep their colors.",
                "Delete theme",
                WMessageBoxButtons.YesNo,
                WMessageBoxImage.Exclamation);
            if (result != WMessageBoxResult.Yes)
            {
                return;
            }

            try
            {
                ThemeService.Delete(theme);
            }
            catch (Exception ex)
            {
                ShowError("Could not delete theme", ex);
            }
        }

        public static void Import(Window owner = null)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Import theme",
                Filter = "WolvenKit theme (*.json)|*.json",
                Multiselect = false
            };
            if (dialog.ShowDialog(owner ?? DefaultOwner) != true)
            {
                return;
            }

            ThemeDto imported;
            try
            {
                imported = ThemeService.Import(dialog.FileName);
            }
            catch (Exception ex)
            {
                ShowError("Could not import theme", ex);
                return;
            }

            var result = Interactions.ShowMessageBox(
                $"Theme \"{imported.Name}\" was imported. Use it now?",
                "Theme imported",
                WMessageBoxButtons.YesNo,
                WMessageBoxImage.Question);
            if (result == WMessageBoxResult.Yes)
            {
                ThemeService.SetActive(imported.Name);
            }
        }

        public static void OpenThemesFolder() =>
            Process.Start(new ProcessStartInfo(IThemeService.GetUserThemesDir()) { UseShellExecute = true });

        private static void ShowError(string caption, Exception ex) =>
            Interactions.ShowMessageBox(ex.Message, caption, WMessageBoxButtons.Ok, WMessageBoxImage.Error);
    }
}
