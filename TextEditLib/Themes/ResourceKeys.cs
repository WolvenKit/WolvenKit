namespace TextEditLib.Themes
{
	using System.Windows;

	public static class ResourceKeys
	{
		#region Accent Keys
		/// <summary>
		/// Accent Color Key - This Color key is used to accent elements in the UI
		/// (e.g.: Color of Activated Normal Window Frame, ResizeGrip, Focus or MouseOver input elements)
		/// </summary>
		public static readonly ComponentResourceKey ControlAccentColorKey = new ComponentResourceKey(typeof(ResourceKeys), "ControlAccentColorKey");

		/// <summary>
		/// Accent Brush Key - This Brush key is used to accent elements in the UI
		/// (e.g.: Color of Activated Normal Window Frame, ResizeGrip, Focus or MouseOver input elements)
		/// </summary>
		public static readonly ComponentResourceKey ControlAccentBrushKey = new ComponentResourceKey(typeof(ResourceKeys), "ControlAccentBrushKey");
		#endregion Accent Keys

		#region TextEditor BrushKeys
		public static readonly ComponentResourceKey EditorBackground = new ComponentResourceKey(typeof(ResourceKeys), "EditorBackground");
		public static readonly ComponentResourceKey EditorForeground = new ComponentResourceKey(typeof(ResourceKeys), "EditorForeground");
		public static readonly ComponentResourceKey EditorLineNumbersForeground = new ComponentResourceKey(typeof(ResourceKeys), "EditorLineNumbersForeground");
		public static readonly ComponentResourceKey EditorSelectionBrush = new ComponentResourceKey(typeof(ResourceKeys), "EditorSelectionBrush");
		public static readonly ComponentResourceKey EditorSelectionBorder = new ComponentResourceKey(typeof(ResourceKeys), "EditorSelectionBorder");
		public static readonly ComponentResourceKey EditorNonPrintableCharacterBrush = new ComponentResourceKey(typeof(ResourceKeys), "EditorNonPrintableCharacterBrush");
		public static readonly ComponentResourceKey EditorLinkTextForegroundBrush = new ComponentResourceKey(typeof(ResourceKeys), "EditorLinkTextForegroundBrush");
		public static readonly ComponentResourceKey EditorLinkTextBackgroundBrush = new ComponentResourceKey(typeof(ResourceKeys), "EditorLinkTextBackgroundBrush");

		public static readonly ComponentResourceKey HighlightTextBrushKey = new ComponentResourceKey(typeof(ResourceKeys), "HighlightTextBrushKey");

		#region DiffView Currentline Keys
		/// <summary>
		/// Gets the background color for highlighting for the currently highlighed line.
		/// </summary>
		public static readonly ComponentResourceKey EditorCurrentLineBackgroundBrushKey = new ComponentResourceKey(typeof(ResourceKeys), "EditorCurrentLineBackgroundBrushKey");

		/// <summary>
		/// Gets the border color for highlighting for the currently highlighed line.
		/// </summary>
		public static readonly ComponentResourceKey EditorCurrentLineBorderBrushKey = new ComponentResourceKey(typeof(ResourceKeys), "EditorCurrentLineBorderBrushKey");

		/// <summary>
		/// Gets the border thickness for highlighting for the currently highlighed line.
		/// </summary>
		public static readonly ComponentResourceKey EditorCurrentLineBorderThicknessKey = new ComponentResourceKey(typeof(ResourceKeys), "EditorCurrentLineBorderThicknessKey");
		#endregion DiffView Currentline Keys
		#endregion TextEditor BrushKeys
	}
}
