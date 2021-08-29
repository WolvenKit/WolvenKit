using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SquadMemberBaseComponent : gameSquadMemberComponent
	{
		private CWeakHandle<gamedataAISquadParams_Record> _baseSquadRecord;

		[Ordinal(4)] 
		[RED("baseSquadRecord")] 
		public CWeakHandle<gamedataAISquadParams_Record> BaseSquadRecord
		{
			get => GetProperty(ref _baseSquadRecord);
			set => SetProperty(ref _baseSquadRecord, value);
		}
	}
}
