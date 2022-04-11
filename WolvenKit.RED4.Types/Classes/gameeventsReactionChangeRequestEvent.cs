using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsReactionChangeRequestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("reactionPresetRecord")] 
		public CHandle<gamedataReactionPreset_Record> ReactionPresetRecord
		{
			get => GetPropertyValue<CHandle<gamedataReactionPreset_Record>>();
			set => SetPropertyValue<CHandle<gamedataReactionPreset_Record>>(value);
		}
	}
}
