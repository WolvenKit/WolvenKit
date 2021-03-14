using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsReactionChangeRequestEvent : redEvent
	{
		private CHandle<gamedataReactionPreset_Record> _reactionPresetRecord;

		[Ordinal(0)] 
		[RED("reactionPresetRecord")] 
		public CHandle<gamedataReactionPreset_Record> ReactionPresetRecord
		{
			get
			{
				if (_reactionPresetRecord == null)
				{
					_reactionPresetRecord = (CHandle<gamedataReactionPreset_Record>) CR2WTypeManager.Create("handle:gamedataReactionPreset_Record", "reactionPresetRecord", cr2w, this);
				}
				return _reactionPresetRecord;
			}
			set
			{
				if (_reactionPresetRecord == value)
				{
					return;
				}
				_reactionPresetRecord = value;
				PropertySet(this);
			}
		}

		public gameeventsReactionChangeRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
