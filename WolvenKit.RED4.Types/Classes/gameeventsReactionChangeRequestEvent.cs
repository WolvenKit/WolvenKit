using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsReactionChangeRequestEvent : redEvent
	{
		private CHandle<gamedataReactionPreset_Record> _reactionPresetRecord;

		[Ordinal(0)] 
		[RED("reactionPresetRecord")] 
		public CHandle<gamedataReactionPreset_Record> ReactionPresetRecord
		{
			get => GetProperty(ref _reactionPresetRecord);
			set => SetProperty(ref _reactionPresetRecord, value);
		}
	}
}
