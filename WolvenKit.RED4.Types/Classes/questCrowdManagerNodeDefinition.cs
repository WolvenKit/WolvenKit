using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCrowdManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questICrowdManager_NodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questICrowdManager_NodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
