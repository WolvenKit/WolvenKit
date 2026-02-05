#nullable enable

using System;
using System.Windows;
using System.Windows.Input;
using Syncfusion.Windows.Controls.Input;

namespace WolvenKit.Views.Controls
{
    public class PasteEventArgs : EventArgs
    {
        public PasteEventArgs(string text)
        {
            Text = text;
            Handled = false;
        }

        /// <summary>
        /// Text content from the clipboard being pasted into the textbox
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Set to true to cancel the paste operation (e.g. if you're setting the textbox value yourself)
        /// </summary>
        public bool Handled { get; set; }
    }

    public class TextboxExtWithPasteHandler : SfTextBoxExt
    {
        public event EventHandler<PasteEventArgs>? OnPaste;

        public TextboxExtWithPasteHandler()
        {
            DataObject.AddPastingHandler(this, OnPasteHandler);
            PreviewKeyDown += OnPreviewKeyDownHandler;
        }

        public bool ConvertNewlineToComma { get; set; } = false;
        public bool RemoveNewLines { get; set; } = false;

        private void OnPasteHandler(object sender, DataObjectPastingEventArgs e)
        {
            if (e.FormatToApply != DataFormats.Text &&
                e.FormatToApply != DataFormats.UnicodeText ||
                !e.DataObject.GetDataPresent(DataFormats.Text) ||
                e.DataObject.GetData(DataFormats.Text) is not string original)
            {
                return;
            }

            var processed = ProcessText(original);

            if (processed == null)
            {
                // Handler requested cancel
                e.CancelCommand();
                return;
            }

            e.CancelCommand();
            PasteCustomText(processed);
        }

        private void OnPreviewKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.V || (Keyboard.Modifiers & ModifierKeys.Control) != ModifierKeys.Control)
            {
                return;
            }

            e.Handled = true;
            PasteFromClipboard();
        }

        private void PasteFromClipboard()
        {
            if (!Clipboard.ContainsText())
            {
                return;
            }

            var text = Clipboard.GetText();
            if (ProcessText(text) is not string processed)
            {
                return;
            }

            PasteCustomText(processed);
        }

        private void PasteCustomText(string text)
        {
            var start = SelectionStart;
            var length = SelectionLength;

            var current = Text;

            if (length > 0)
            {
                current = current.Remove(start, length);
            }

            SetCurrentValue(TextProperty, current.Insert(start, text));
            SelectionStart = start + text.Length;
            SelectionLength = 0;
        }

        private string? ProcessText(string input)
        {
            if (RemoveNewLines)
            {
                input = input.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
            }

            if (ConvertNewlineToComma)
            {
                input = input.Replace("\r\n", ",").Replace("\n", ",").Replace("\r", ",");
            }

            var args = new PasteEventArgs(input);
            OnPaste?.Invoke(this, args);

            if (args.Handled)
            {
                return null;
            }

            return args.Text;
        }
    }
}
