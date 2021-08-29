using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameUnequipByContextRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gameItemUnequipContexts> _itemUnequipContext;

		[Ordinal(1)] 
		[RED("itemUnequipContext")] 
		public CEnum<gameItemUnequipContexts> ItemUnequipContext
		{
			get => GetProperty(ref _itemUnequipContext);
			set => SetProperty(ref _itemUnequipContext, value);
		}
	}
}
