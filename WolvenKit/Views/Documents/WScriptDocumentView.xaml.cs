using System;
using System.Reactive.Disposables;
using System.Text;
using System.Windows.Input;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using ReactiveUI;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents;
/// <summary>
/// Interaktionslogik für WScriptDocumentView.xaml
/// </summary>
public partial class WScriptDocumentView
{
    private CompletionWindow _completionWindow;

    public WScriptDocumentView()
    {
        InitializeComponent();

        ScriptTextEditor.Document = new TextDocument();
        ScriptTextEditor.Document.TextChanged += ScriptTextEditor_Document_TextChanged;
        ScriptTextEditor.TextArea.TextEntered += ScriptTextEditor_TextArea_TextEntered;

        this.WhenActivated(disposables =>
        {
            if (DataContext is WScriptDocumentViewModel vm)
            {
                SetCurrentValue(ViewModelProperty, vm);
            }

            this.WhenAnyValue(x => x.ViewModel.Text)
                .Subscribe(text =>
                {
                    if (ScriptTextEditor.Document.Text != text)
                    {
                        ScriptTextEditor.Document.Text = text;
                    }
                })
                .DisposeWith(disposables);
        });
    }

    private void ScriptTextEditor_Document_TextChanged(object sender, EventArgs e)
    {
        if (ViewModel != null && ViewModel.Text != ScriptTextEditor.Document.Text)
        {
            ViewModel.Text = ScriptTextEditor.Document.Text;
        }
    }

    private void ScriptTextEditor_TextArea_TextEntered(object sender, TextCompositionEventArgs e)
    {
        ViewModel.SetIsDirty(true);
        if (e.Text == ".")
        {
            ShowCompletionWindow();
        }
    }

    private string GetCurrentLine()
    {
        var lineNo = ScriptTextEditor.TextArea.Caret.Line;
        var line = ScriptTextEditor.Document.GetLineByNumber(lineNo);
        return ScriptTextEditor.Document.GetText(line);
    }

    private string GetVarName()
    {
        var line = GetCurrentLine();

        var sb = new StringBuilder();
        for (int i = line.Length - 2; i >= 0; i--)
        {
            if (!char.IsLetter(line[i]))
            {
                break;
            }

            sb.Insert(0, line[i]);
        }

        return sb.ToString();
    }

    private void ShowCompletionWindow()
    {
        var varName = GetVarName();

        if (ViewModel != null && ViewModel.CompletionData.TryGetValue(varName, out var lst))
        {
            _completionWindow = new CompletionWindow(ScriptTextEditor.TextArea);

            foreach (var valueTuple in lst)
            {
                _completionWindow.CompletionList.CompletionData.Add(new MyCompletionData(valueTuple.name, valueTuple.desc));
            }

            _completionWindow.Show();
            _completionWindow.Closed += delegate {
                _completionWindow = null;
            };
        }
    }

    private class MyCompletionData : ICompletionData
    {
        public MyCompletionData(string text, string description)
        {
            Text = text;
            Description = description;
        }

        public System.Windows.Media.ImageSource Image => null;

        public string Text { get; }

        // Use this property if you want to show a fancy UIElement in the list.
        public object Content => Text;

        public object Description { get; }

        public double Priority { get; set; }

        public void Complete(TextArea textArea, ISegment completionSegment, EventArgs insertionRequestEventArgs)
        {
            textArea.Document.Replace(completionSegment, this.Text);
        }
    }
}
