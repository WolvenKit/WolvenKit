using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalMetaQuestObjective : gameJournalEntry
	{
		private LocalizationString _description;
		private CUInt32 _progressPercent;
		private TweakDBID _iconID;

		[Ordinal(1)] 
		[RED("description")] 
		public LocalizationString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("progressPercent")] 
		public CUInt32 ProgressPercent
		{
			get
			{
				if (_progressPercent == null)
				{
					_progressPercent = (CUInt32) CR2WTypeManager.Create("Uint32", "progressPercent", cr2w, this);
				}
				return _progressPercent;
			}
			set
			{
				if (_progressPercent == value)
				{
					return;
				}
				_progressPercent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get
			{
				if (_iconID == null)
				{
					_iconID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "iconID", cr2w, this);
				}
				return _iconID;
			}
			set
			{
				if (_iconID == value)
				{
					return;
				}
				_iconID = value;
				PropertySet(this);
			}
		}

		public gameJournalMetaQuestObjective(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
