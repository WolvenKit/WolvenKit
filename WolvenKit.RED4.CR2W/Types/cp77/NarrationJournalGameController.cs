using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NarrationJournalGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _entriesContainer;
		private CUInt32 _narrationJournalBlackboardId;

		[Ordinal(9)] 
		[RED("entriesContainer")] 
		public inkCompoundWidgetReference EntriesContainer
		{
			get
			{
				if (_entriesContainer == null)
				{
					_entriesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "entriesContainer", cr2w, this);
				}
				return _entriesContainer;
			}
			set
			{
				if (_entriesContainer == value)
				{
					return;
				}
				_entriesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("narrationJournalBlackboardId")] 
		public CUInt32 NarrationJournalBlackboardId
		{
			get
			{
				if (_narrationJournalBlackboardId == null)
				{
					_narrationJournalBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "narrationJournalBlackboardId", cr2w, this);
				}
				return _narrationJournalBlackboardId;
			}
			set
			{
				if (_narrationJournalBlackboardId == value)
				{
					return;
				}
				_narrationJournalBlackboardId = value;
				PropertySet(this);
			}
		}

		public NarrationJournalGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
