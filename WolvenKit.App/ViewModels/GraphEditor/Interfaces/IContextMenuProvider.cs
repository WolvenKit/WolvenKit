using System;
using System.Windows;
using System.Windows.Controls;

namespace WolvenKit.App.ViewModels.GraphEditor;

public interface IContextMenuProvider
{
    void OnContextMenu(ContextMenu contextMenu, UIElement mainView);
}