using Splat;
using System.Threading.Tasks;
using System.Windows.Controls;
using System;
using System.Windows;
using Microsoft.Xaml.Behaviors;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Views.Dialogs.Windows;
using WolvenKit.Views.Shell;

namespace WolvenKit.Services;

/// <summary>
/// Provides methods to display dialogs and modals in the application.
/// </summary>
/// <remarks>
/// <para>
/// This service is a behavior that is attached to the <see cref="MainView"/> to display dialogs and modals.
/// </para>
/// <para>
/// To use it, the ViewModel needs to be registered in the <see cref="GenericHost"/>.
/// <code>
/// <![CDATA[
/// services.AddTransient<IViewFor<TViewModel>, TView>();
/// ]]>
/// </code>
/// </para>
/// <para>
/// ShowDialog supports both <see cref="Window"/> and <see cref="UserControl"/> as Views.
/// ShowModal supports only <see cref="UserControl"/> as Views.
/// </para>
/// </remarks>
public class DialogService : Behavior<MainView>, IDialogService
{
    protected override void OnAttached()
    {
        // Pass down AssociatedObject to the DialogService registered in the Locator

        var realService = Locator.Current.GetService<IDialogService>();
        if (realService is not Behavior<MainView> realBehavior)
        {
            throw new Exception();
        }

        if (ReferenceEquals(this, realService))
        {
            return;
        }

        realBehavior.Attach(AssociatedObject);
    }

    private UserControl GetUserControl(DialogExtViewModel viewModel)
    {
        var view = ReactiveUI.ViewLocator.Current.ResolveView(viewModel);
        if (view == null)
        {
            throw new Exception($"View for \"{viewModel.GetType().Name}\" could not be found!");
        }

        view.ViewModel ??= viewModel;

        if (view is UserControl userControl)
        {
            return userControl;
        }

        throw new Exception($"View for \"{viewModel.GetType().Name}\" needs to be \"UserControl\"!");
    }

    private Window GetWindow(DialogExtViewModel viewModel)
    {
        var view = ReactiveUI.ViewLocator.Current.ResolveView(viewModel);
        if (view == null)
        {
            throw new Exception($"View for \"{viewModel.GetType().Name}\" could not be found!");
        }

        view.ViewModel ??= viewModel;

        if (view is Window window)
        {
            window.Owner = AssociatedObject;

            return window;
        }

        if (view is UserControl userControl)
        {
            window = new DialogWindow(userControl)
            {
                Owner = AssociatedObject
            };

            return window;
        }

        throw new Exception($"View for \"{viewModel.GetType().Name}\" needs to be \"Window\" or \"UserControl\"!");
    }

    /// <inheritdoc />
    public bool? ShowDialog(DialogExtViewModel viewModel)
    {
        if (AssociatedObject.ViewModel == null)
        {
            throw new Exception();
        }

        return GetWindow(viewModel).ShowDialog();
    }

    /// <inheritdoc />
    public void ShowDialog<T>(T viewModel, Action<T> callback) where T : DialogExtViewModel
    {
        if (AssociatedObject.ViewModel == null)
        {
            return;
        }

        GetWindow(viewModel).ShowDialog();

        callback(viewModel);
    }

    /// <inheritdoc />
    public void ShowDialog<T>(T viewModel, Func<T, Task> callback) where T : DialogExtViewModel
    {
        if (AssociatedObject.ViewModel == null)
        {
            return;
        }

        GetWindow(viewModel).ShowDialog();

        callback(viewModel);
    }

    /// <inheritdoc />
    public void ShowModal(DialogExtViewModel viewModel)
    {
        if (AssociatedObject.ViewModel == null)
        {
            return;
        }

        var userControl = GetUserControl(viewModel);

        EventHandler eventHandler = null;
        eventHandler = (sender, args) =>
        {
            viewModel.Closed -= eventHandler;

            AssociatedObject.ViewModel.IsDialogShown = false;
            AssociatedObject.ViewModel.ShouldDialogShow = false;
        };
        viewModel.Closed += eventHandler;

        AssociatedObject.ModalContent.SetCurrentValue(ContentControl.ContentProperty, userControl);
        AssociatedObject.ViewModel.IsDialogShown = true;
        AssociatedObject.ViewModel.ShouldDialogShow = true;
    }

    /// <inheritdoc />
    public void ShowModal<T>(T viewModel, Action<T> callback) where T : DialogExtViewModel
    {
        if (AssociatedObject.ViewModel == null)
        {
            return;
        }

        var userControl = GetUserControl(viewModel);

        EventHandler eventHandler = null;
        eventHandler = (sender, args) =>
        {
            viewModel.Closed -= eventHandler;

            AssociatedObject.ViewModel.IsDialogShown = false;
            AssociatedObject.ViewModel.ShouldDialogShow = false;

            callback(viewModel);
        };
        viewModel.Closed += eventHandler;

        AssociatedObject.ModalContent.SetCurrentValue(ContentControl.ContentProperty, userControl);
        AssociatedObject.ViewModel.IsDialogShown = true;
        AssociatedObject.ViewModel.ShouldDialogShow = true;
    }

    /// <inheritdoc />
    public void ShowModal<T>(T viewModel, Func<T, Task> callback) where T : DialogExtViewModel
    {
        if (AssociatedObject.ViewModel == null)
        {
            return;
        }

        var userControl = GetUserControl(viewModel);

        EventHandler eventHandler = null;
        eventHandler = async void (sender, args) =>
        {
            viewModel.Closed -= eventHandler;

            AssociatedObject.ViewModel.IsDialogShown = false;
            AssociatedObject.ViewModel.ShouldDialogShow = false;

            await callback(viewModel);
        };
        viewModel.Closed += eventHandler;

        AssociatedObject.ModalContent.SetCurrentValue(ContentControl.ContentProperty, userControl);
        AssociatedObject.ViewModel.IsDialogShown = true;
        AssociatedObject.ViewModel.ShouldDialogShow = true;
    }
}