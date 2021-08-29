using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsEditorObjectIDPath : RedBaseClass
	{
		private CArray<EditorObjectID> _elements;

		[Ordinal(0)] 
		[RED("elements")] 
		public CArray<EditorObjectID> Elements
		{
			get => GetProperty(ref _elements);
			set => SetProperty(ref _elements, value);
		}
	}
}
