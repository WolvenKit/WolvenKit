using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameUnequipByContextRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("itemUnequipContext")] 
		public CEnum<gameItemUnequipContexts> ItemUnequipContext
		{
			get => GetPropertyValue<CEnum<gameItemUnequipContexts>>();
			set => SetPropertyValue<CEnum<gameItemUnequipContexts>>(value);
		}
	}
}
