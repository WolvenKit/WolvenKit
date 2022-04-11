using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootSlotSingleQuery : gameLootSlot
	{
		[Ordinal(48)] 
		[RED("queryTDBID")] 
		public TweakDBID QueryTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameLootSlotSingleQuery()
		{
			UseAreaLoot = false;
		}
	}
}
