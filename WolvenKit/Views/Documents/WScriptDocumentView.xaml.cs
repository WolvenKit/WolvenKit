using System;
using System.Windows;
using System.Windows.Input;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using ReactiveUI;
using WolvenKit.ViewModels.Documents;

namespace WolvenKit.Views.Documents;
/// <summary>
/// Interaktionslogik für WScriptDocumentView.xaml
/// </summary>
public partial class WScriptDocumentView
{
    // private CompletionWindow _completionWindow;

    public WScriptDocumentView()
    {
        InitializeComponent();

        ScriptTextEditor.TextArea.TextEntering += ScriptTextEditor_TextArea_TextEntering;

        this.WhenActivated(disposables =>
        {
            if (DataContext is WScriptDocumentViewModel vm)
            {
                SetCurrentValue(ViewModelProperty, vm);
            }
        });
    }

    private void ScriptTextEditor_TextArea_TextEntering(object sender, TextCompositionEventArgs e)
    {
        //if (e.Text == ".")
        //{
        //    _completionWindow = new CompletionWindow(ScriptTextEditor.TextArea);
        //    var data = _completionWindow.CompletionList.CompletionData;
        //    data.Add(new MyCompletionData("Info"));
        //    data.Add(new MyCompletionData("Error"));
        //    _completionWindow.Show();
        //    _completionWindow.Closed += delegate {
        //        _completionWindow = null;
        //    };
        //}
    }

    private class MyCompletionData : ICompletionData
    {
        public MyCompletionData(string text)
        {
            this.Text = text;
        }

        public System.Windows.Media.ImageSource Image
        {
            get { return null; }
        }

        public string Text { get; private set; }

        // Use this property if you want to show a fancy UIElement in the list.
        public object Content
        {
            get { return this.Text; }
        }

        public object Description
        {
            get { return "Description for " + this.Text; }
        }

        public double Priority { get; set; }

        public void Complete(TextArea textArea, ISegment completionSegment, EventArgs insertionRequestEventArgs)
        {
            textArea.Document.Replace(completionSegment, this.Text);
        }
    }
}
