using ICSharpCode.AvalonEdit.Highlighting;
using System.Collections.ObjectModel;
using TextEditLib.Interfaces;

namespace TextEditLib.ViewModels
{
	/// <summary>
	/// Implements an adapter to wrap properties and methods available from
	/// the <see cref="HighlightingManager"/> interface.
	/// </summary>
	internal class HighLightingManagerAdapter : IHighLightingManagerAdapter
	{
		#region fields
		private readonly HighlightingManager _hlManager;
		#endregion fields

		#region ctors
		/// <summary>
		/// Class constructor
		/// </summary>
		/// <param name="hlManager"></param>
		public HighLightingManagerAdapter(HighlightingManager hlManager)
		{
			_hlManager = hlManager;
		}
		#endregion ctors

		/// <summary>
		/// Gets a copy of all highlightings.
		/// </summary>
		public ReadOnlyCollection<IHighlightingDefinition> HighlightingDefinitions => _hlManager.HighlightingDefinitions;

		#region methods
		/// <summary>
		/// Gets a highlighting definition by name. Returns null if the definition is not found.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public IHighlightingDefinition GetDefinition(string name)
		{
			return _hlManager.GetDefinition(name);
		}

		/// <summary>
		/// Gets a highlighting definition by extension. Returns null if the definition is not found.
		/// </summary>
		/// <param name="extension"></param>
		/// <returns></returns>
		public IHighlightingDefinition GetDefinitionByExtension(string extension)
		{
			return _hlManager.GetDefinitionByExtension(extension);
		}
		#endregion methods
	}
}
