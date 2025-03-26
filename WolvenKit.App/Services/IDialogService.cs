using System.Threading.Tasks;
using System;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.Services;

/// <summary>
/// Provides methods to display dialogs and modals in the application.
/// </summary>
public interface IDialogService
{
    /// <summary>
    /// Displays a dialog for the specified view model.
    /// </summary>
    /// <param name="viewModel">The view model for the dialog.</param>
    /// <returns>A nullable boolean indicating the result of the dialog.</returns>
    public bool? ShowDialog(DialogExtViewModel viewModel);

    /// <summary>
    /// Displays a dialog for the specified view model and executes a callback upon completion.
    /// </summary>
    /// <typeparam name="T">The type of the view model, which must inherit from <see cref="DialogExtViewModel"/>.</typeparam>
    /// <param name="viewModel">The view model for the dialog.</param>
    /// <param name="callback">The callback to execute upon completion.</param>
    public void ShowDialog<T>(T viewModel, Action<T> callback) where T : DialogExtViewModel;

    /// <summary>
    /// Displays a dialog for the specified view model and executes an asynchronous callback upon completion.
    /// </summary>
    /// <typeparam name="T">The type of the view model, which must inherit from <see cref="DialogExtViewModel"/>.</typeparam>
    /// <param name="viewModel">The view model for the dialog.</param>
    /// <param name="callback">The asynchronous callback to execute upon completion.</param>
    public void ShowDialog<T>(T viewModel, Func<T, Task> callback) where T : DialogExtViewModel;

    /// <summary>
    /// Displays a modal dialog for the specified view model.
    /// </summary>
    /// <param name="viewModel">The view model for the modal dialog.</param>
    public void ShowModal(DialogExtViewModel viewModel);

    /// <summary>
    /// Displays a modal dialog for the specified view model and executes a callback upon completion.
    /// </summary>
    /// <typeparam name="T">The type of the view model, which must inherit from <see cref="DialogExtViewModel"/>.</typeparam>
    /// <param name="viewModel">The view model for the modal dialog.</param>
    /// <param name="callback">The callback to execute upon completion.</param>
    public void ShowModal<T>(T viewModel, Action<T> callback) where T : DialogExtViewModel;

    /// <summary>
    /// Displays a modal dialog for the specified view model and executes an asynchronous callback upon completion.
    /// </summary>
    /// <typeparam name="T">The type of the view model, which must inherit from <see cref="DialogExtViewModel"/>.</typeparam>
    /// <param name="viewModel">The view model for the modal dialog.</param>
    /// <param name="callback">The asynchronous callback to execute upon completion.</param>
    public void ShowModal<T>(T viewModel, Func<T, Task> callback) where T : DialogExtViewModel;
}