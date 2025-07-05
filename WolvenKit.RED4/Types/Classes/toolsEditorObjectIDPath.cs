using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsEditorObjectIDPath : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("elements")] 
		public CArray<EditorObjectID> Elements
		{
			get => GetPropertyValue<CArray<EditorObjectID>>();
			set => SetPropertyValue<CArray<EditorObjectID>>(value);
		}

		public toolsEditorObjectIDPath()
		{
			Elements = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
