using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetMultiplayerHeistState_NodeType : questIMultiplayerHeistNodeType
	{
		private CEnum<questMultiplayerHeistState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<questMultiplayerHeistState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
