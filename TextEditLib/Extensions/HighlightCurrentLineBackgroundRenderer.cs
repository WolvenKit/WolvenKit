using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Rendering;
using System.Windows.Media;
using System.Windows;

namespace TextEditLib.Extensions
{
	/// <summary>
	/// AvalonEdit: highlight current line even when not focused
	/// 
	/// Source: http://stackoverflow.com/questions/5072761/avalonedit-highlight-current-line-even-when-not-focused
	/// </summary>
	internal class HighlightCurrentLineBackgroundRenderer : IBackgroundRenderer
	{
		#region fields
		private readonly TextEdit _Editor;
		#endregion fields

		#region ctors
		/// <summary>
		/// Class Constructor from editor and SolidColorBrush definition
		/// </summary>
		/// <param name="editor"></param>
		public HighlightCurrentLineBackgroundRenderer(TextEdit editor)
			: this()
		{
			_Editor = editor;
		}

		/// <summary>
		/// Hidden class standard constructor
		/// </summary>
		protected HighlightCurrentLineBackgroundRenderer()
		{
			// Nothing to initialize here...
		}
		#endregion ctors

		#region properties
		/// <summary>
		/// Get the <seealso cref="KnownLayer"/> of the <seealso cref="TextEditor"/> control.
		/// </summary>
		public KnownLayer Layer
		{
			get { return KnownLayer.Background; }
		}
		#endregion properties

		#region methods
		/// <summary>
		/// Draw the background line highlighting of the current line.
		/// </summary>
		/// <param name="textView"></param>
		/// <param name="drawingContext"></param>
		public void Draw(TextView textView, DrawingContext drawingContext)
		{
			if (this._Editor == null)
				return;

			if (this._Editor.Document == null)
				return;

			if (this._Editor.Document.TextLength == 0)
				return;

			if (_Editor.EditorCurrentLineBorderThickness == 0 && _Editor.EditorCurrentLineBackground == null)
				return;

			Pen borderPen = null;

			if (_Editor.EditorCurrentLineBorder != null)
			{
				borderPen = new Pen(_Editor.EditorCurrentLineBorder, _Editor.EditorCurrentLineBorderThickness);

				if (borderPen.CanFreeze)
					borderPen.Freeze();
			}

			if (_Editor.EditorCurrentLineBackground != null)
			{
				textView.EnsureVisualLines();
				var currentLine = _Editor.Document.GetLineByOffset(_Editor.CaretOffset);

				foreach (var rect in BackgroundGeometryBuilder.GetRectsForSegment(textView, currentLine))
				{
					drawingContext.DrawRectangle(_Editor.EditorCurrentLineBackground, borderPen,
												 new Rect(rect.Location, new Size(textView.ActualWidth, rect.Height)));
				}
			}
		}
		#endregion methods
	}
}
