using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldOffMeshSmartObjectNode : worldOffMeshConnectionNode
	{
		private CHandle<gameSmartObjectDefinition> _object;

		[Ordinal(13)] 
		[RED("object")] 
		public CHandle<gameSmartObjectDefinition> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}
	}
}
