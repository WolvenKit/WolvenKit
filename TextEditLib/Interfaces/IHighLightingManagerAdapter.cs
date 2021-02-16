using ICSharpCode.AvalonEdit.Highlighting;
using System.Collections.ObjectModel;

namespace TextEditLib.Interfaces
{
	/// <summary>
	/// Implements an adapter to wrap properties and methods available from
	/// different  (generic or themed) HighlightingManager implementations.
	/// </summary>
	public interface IHighLightingManagerAdapter
	{
		/// <summary>
		/// Gets a copy of all highlightings.
		/// </summary>
		ReadOnlyCollection<IHighlightingDefinition> HighlightingDefinitions { get; }

		/// <summary>
		/// Gets a highlighting definition by name. Returns null if the definition is not found.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		IHighlightingDefinition GetDefinition(string name);

		/// <summary>
		/// Gets a highlighting definition by extension. Returns null if the definition is not found.
		/// </summary>
		/// <param name="extension"></param>
		/// <returns></returns>
		IHighlightingDefinition GetDefinitionByExtension(string extension);
	}
}
