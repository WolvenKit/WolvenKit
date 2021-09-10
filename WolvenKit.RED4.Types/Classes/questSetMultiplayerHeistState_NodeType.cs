using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetMultiplayerHeistState_NodeType : questIMultiplayerHeistNodeType
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<questMultiplayerHeistState> State
		{
			get => GetPropertyValue<CEnum<questMultiplayerHeistState>>();
			set => SetPropertyValue<CEnum<questMultiplayerHeistState>>(value);
		}
	}
}
