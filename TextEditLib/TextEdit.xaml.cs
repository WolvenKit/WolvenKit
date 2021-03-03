using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Folding;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Rendering;
using TextEditLib.Extensions;
using TextEditLib.Foldings;

namespace TextEditLib
{
    /// <summary>
    /// Implements an AvalonEdit control textedit control with extensions.
    /// </summary>
    public class TextEdit : TextEditor
    {
        #region fields

        #region EditorCurrentLine Highlighting Colors

        private static readonly DependencyProperty EditorCurrentLineBackgroundProperty =
            DependencyProperty.Register("EditorCurrentLineBackground",
                                         typeof(Brush),
                                         typeof(TextEdit),
                                         new UIPropertyMetadata(new SolidColorBrush(Colors.Transparent)));

        public static readonly DependencyProperty EditorCurrentLineBorderProperty =
            DependencyProperty.Register("EditorCurrentLineBorder", typeof(Brush),
                typeof(TextEdit), new PropertyMetadata(new SolidColorBrush(
                    Color.FromArgb(0x60, SystemColors.HighlightBrush.Color.R,
                                         SystemColors.HighlightBrush.Color.G,
                                         SystemColors.HighlightBrush.Color.B))));

        public static readonly DependencyProperty EditorCurrentLineBorderThicknessProperty =
            DependencyProperty.Register("EditorCurrentLineBorderThickness", typeof(double),
                typeof(TextEdit), new PropertyMetadata(2.0d));

        #endregion EditorCurrentLine Highlighting Colors

        #region CaretPosition

        private static readonly DependencyProperty ColumnProperty =
            DependencyProperty.Register("Column", typeof(int),
                typeof(TextEdit), new UIPropertyMetadata(1));

        private static readonly DependencyProperty LineProperty =
            DependencyProperty.Register("Line", typeof(int),
                typeof(TextEdit), new UIPropertyMetadata(1));

        #endregion CaretPosition

        /// <summary>
        /// SyntaxHighlighting Dependency Property
        /// </summary>
        public static readonly new DependencyProperty SyntaxHighlightingProperty =
            TextEditor.SyntaxHighlightingProperty.AddOwner(typeof(TextEdit), new FrameworkPropertyMetadata(OnSyntaxHighlightingChanged));

        /// <summary>
        /// Document property.
        /// </summary>
        public static readonly new DependencyProperty DocumentProperty
            = TextView.DocumentProperty.AddOwner(
                typeof(TextEdit), new FrameworkPropertyMetadata(OnDocumentChanged));

        private FoldingManager mFoldingManager = null;
        private object mFoldingStrategy = null;

        #endregion fields

        #region ctors

        /// <summary>
        /// Static class constructor
        /// </summary>
        static TextEdit()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextEdit),
                new FrameworkPropertyMetadata(typeof(TextEdit)));
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        public TextEdit()
        {
            if (DesignerProperties.GetIsInDesignMode(this))
                return;

            Loaded += TextEdit_Loaded;
            Unloaded += TextEdit_Unloaded;

            CommandBindings.Add(new CommandBinding(TextEditCommands.FoldsCollapseAll, TextEdit.FoldsCollapseAll, TextEdit.FoldsColapseExpandCanExecute));
            CommandBindings.Add(new CommandBinding(TextEditCommands.FoldsExpandAll, TextEdit.FoldsExpandAll, TextEdit.FoldsColapseExpandCanExecute));
        }

        #endregion ctors

        #region properties

        #region EditorCurrentLine Highlighting Colors

        /// <summary>
        /// Gets/sets the background color of the current editor line.
        /// </summary>
        public Brush EditorCurrentLineBackground
        {
            get { return (Brush)GetValue(EditorCurrentLineBackgroundProperty); }
            set { SetValue(EditorCurrentLineBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets/sets the border color of the current editor line.
        /// </summary>
        public Brush EditorCurrentLineBorder
        {
            get { return (Brush)GetValue(EditorCurrentLineBorderProperty); }
            set { SetValue(EditorCurrentLineBorderProperty, value); }
        }

        /// <summary>
        /// Gets/sets the the thickness of the border of the current editor line.
        /// </summary>
        public double EditorCurrentLineBorderThickness
        {
            get { return (double)GetValue(EditorCurrentLineBorderThicknessProperty); }
            set { SetValue(EditorCurrentLineBorderThicknessProperty, value); }
        }

        #endregion EditorCurrentLine Highlighting Colors

        #region CaretPosition

        /// <summary>
        /// Get/set the current column of the editor caret.
        /// </summary>
        public int Column
        {
            get
            {
                return (int)GetValue(ColumnProperty);
            }

            set
            {
                SetValue(ColumnProperty, value);
            }
        }

        /// <summary>
        /// Get/set the current line of the editor caret.
        /// </summary>
        public int Line
        {
            get
            {
                return (int)GetValue(LineProperty);
            }

            set
            {
                SetValue(LineProperty, value);
            }
        }

        #endregion CaretPosition

        #endregion properties

        #region methods

        private void TextEdit_Unloaded(object sender, RoutedEventArgs e)
        {
            Unloaded -= TextEdit_Unloaded;

            // Detach mouse wheel CTRL-key zoom support
            this.PreviewMouseWheel -= textEditor_PreviewMouseWheel;
            this.TextArea.Caret.PositionChanged -= Caret_PositionChanged;
        }

        private void TextEdit_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= TextEdit_Loaded;

            AdjustCurrentLineBackground();

            // Attach mouse wheel CTRL-key zoom support
            this.PreviewMouseWheel += new MouseWheelEventHandler(textEditor_PreviewMouseWheel);
            this.TextArea.Caret.PositionChanged += Caret_PositionChanged;
        }

        /// <summary>
        /// This method is triggered on a MouseWheel preview event to check if the user
        /// is also holding down the CTRL Key and adjust the current font size if so.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEditor_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control)
            {
                double fontSize = this.FontSize + e.Delta / 25.0;

                if (fontSize < 6)
                    this.FontSize = 6;
                else
                {
                    if (fontSize > 200)
                        this.FontSize = 200;
                    else
                        this.FontSize = fontSize;
                }

                e.Handled = true;
            }
        }

        /// <summary>
        /// Update Column and Line position properties when caret position is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Caret_PositionChanged(object sender, EventArgs e)
        {
            // this.TextArea.TextView.InvalidateLayer(KnownLayer.Background); //Update current line highlighting

            if (this.TextArea != null)
            {
                this.Column = this.TextArea.Caret.Column;
                this.Line = this.TextArea.Caret.Line;
            }
            else
            {
                this.Column = 0;
                this.Line = 0;
            }
        }

        /// <summary>
        /// Reset the <seealso cref="SolidColorBrush"/> to be used for highlighting the current editor line.
        /// </summary>
        private void AdjustCurrentLineBackground()
        {
            HighlightCurrentLineBackgroundRenderer oldRenderer = null;

            // Make sure there is only one of this type of background renderer
            // Otherwise, we might keep adding and WPF keeps drawing them on top of each other
            foreach (var item in this.TextArea.TextView.BackgroundRenderers)
            {
                if (item != null)
                {
                    if (item is HighlightCurrentLineBackgroundRenderer)
                    {
                        oldRenderer = item as HighlightCurrentLineBackgroundRenderer;
                    }
                }
            }

            if (oldRenderer != null)
                this.TextArea.TextView.BackgroundRenderers.Remove(oldRenderer);

            this.TextArea.TextView.BackgroundRenderers.Add(new HighlightCurrentLineBackgroundRenderer(this));
        }

        #region foldings

        private static void OnSyntaxHighlightingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var textEdit = d as TextEdit;
            if (textEdit != null)
                textEdit.OnChangedFoldingInstance(e);
        }

        private static void OnDocumentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var textEdit = d as TextEdit;
            if (textEdit != null)
                textEdit.OnDocumentChanged(e);
        }

        private void OnDocumentChanged(DependencyPropertyChangedEventArgs e)
        {
            // Clean up and re-install foldings to avoid exception 'Invalid Document' being thrown by StartGeneration
            OnChangedFoldingInstance(e);
        }

        /// <summary>
        /// Method is invoked when the Document or SyntaxHighlightingDefinition dependency property is changed.
        /// This change should always lead to removing and re-installing the correct folding manager and strategy.
        /// </summary>
        /// <param name="e"></param>
        private void OnChangedFoldingInstance(DependencyPropertyChangedEventArgs e)
        {
            try
            {
                // Clean up last installation of folding manager and strategy
                if (mFoldingManager != null)
                {
                    FoldingManager.Uninstall(mFoldingManager);
                    mFoldingManager = null;
                }

                this.mFoldingStrategy = null;
            }
            catch
            {
            }

#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (e == null)
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'
                return;

            var syntaxHighlighting = e.NewValue as IHighlightingDefinition;
            if (syntaxHighlighting == null)
                return;

            switch (syntaxHighlighting.Name)
            {
                case "XML":
                    mFoldingStrategy = new XmlFoldingStrategy();
                    this.TextArea.IndentationStrategy = new ICSharpCode.AvalonEdit.Indentation.DefaultIndentationStrategy();
                    break;

                case "C#":
                case "C++":
                case "PHP":
                case "Java":
                    this.TextArea.IndentationStrategy = new ICSharpCode.AvalonEdit.Indentation.CSharp.CSharpIndentationStrategy(this.Options);
                    mFoldingStrategy = new BraceFoldingStrategy();
                    break;

                default:
                    this.TextArea.IndentationStrategy = new ICSharpCode.AvalonEdit.Indentation.DefaultIndentationStrategy();
                    mFoldingStrategy = null;
                    break;
            }

            if (mFoldingStrategy != null)
            {
                if (mFoldingManager == null)
                    mFoldingManager = FoldingManager.Install(this.TextArea);

                UpdateFoldings();
            }
            else
            {
                if (mFoldingManager != null)
                {
                    FoldingManager.Uninstall(mFoldingManager);
                    mFoldingManager = null;
                }
            }
        }

        private void UpdateFoldings()
        {
            if (mFoldingStrategy is BraceFoldingStrategy)
            {
                ((BraceFoldingStrategy)mFoldingStrategy).UpdateFoldings(mFoldingManager, this.Document);
            }

            if (mFoldingStrategy is XmlFoldingStrategy)
            {
                ((XmlFoldingStrategy)mFoldingStrategy).UpdateFoldings(mFoldingManager, this.Document);
            }
        }

        #region Fold Unfold Command

        /// <summary>
        /// Determines whether a folding command can be executed or not and sets correspondind
        /// <paramref name="e"/>.CanExecute property value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void FoldsColapseExpandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
            e.Handled = true;

            var editoredi = sender as TextEdit;

            if (editoredi == null)
                return;

            if (editoredi.mFoldingManager == null)
                return;

            if (editoredi.mFoldingManager.AllFoldings == null)
                return;

            e.CanExecute = true;
        }

        /// <summary>
        /// Executes the collapse all folds command (which folds all text foldings but the first).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void FoldsCollapseAll(object sender, ExecutedRoutedEventArgs e)
        {
            var editor = sender as TextEdit;

            if (editor == null)
                return;

            editor.CollapseAllTextfoldings();
        }

        /// <summary>
        /// Executes the collapse all folds command (which folds all text foldings but the first).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void FoldsExpandAll(object sender, ExecutedRoutedEventArgs e)
        {
            var editor = sender as TextEdit;

            if (editor == null)
                return;

            editor.ExpandAllTextFoldings();
        }

        /// <summary>
        /// Goes through all foldings in the displayed text and folds them
        /// so that users can explore the text in a top down manner.
        /// </summary>
        private void CollapseAllTextfoldings()
        {
            if (this.mFoldingManager == null)
                return;

            if (this.mFoldingManager.AllFoldings == null)
                return;

            foreach (var loFolding in this.mFoldingManager.AllFoldings)
            {
                loFolding.IsFolded = true;
            }

            // Unfold the first fold (if any) to give a useful overview on content
            FoldingSection foldSection = this.mFoldingManager.GetNextFolding(0);

            if (foldSection != null)
                foldSection.IsFolded = false;
        }

        /// <summary>
        /// Goes through all foldings in the displayed text and unfolds them
        /// so that users can see all text items (without having to play with folding).
        /// </summary>
        private void ExpandAllTextFoldings()
        {
            if (this.mFoldingManager == null)
                return;

            if (this.mFoldingManager.AllFoldings == null)
                return;

            foreach (var loFolding in this.mFoldingManager.AllFoldings)
            {
                loFolding.IsFolded = false;
            }
        }

        #endregion Fold Unfold Command

        #endregion foldings

        #endregion methods
    }
}
