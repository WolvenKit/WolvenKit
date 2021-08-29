using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootSlotSingleQuery : gameLootSlot
	{
		private TweakDBID _queryTDBID;

		[Ordinal(53)] 
		[RED("queryTDBID")] 
		public TweakDBID QueryTDBID
		{
			get => GetProperty(ref _queryTDBID);
			set => SetProperty(ref _queryTDBID, value);
		}
	}
}
