
using Catel.Windows;
using System.Windows;

namespace WolvenKit.Views.CodeEditor
{
    public partial class CodeEditorView
    {
        public CodeEditorView() : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Red"); //This aint needed was just for testing remove me.

        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            SetCurrentValue(WindowStateProperty, System.Windows.WindowState.Minimized);
        }

        private void DataWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Code Editor");
            }
        }
    }
}
