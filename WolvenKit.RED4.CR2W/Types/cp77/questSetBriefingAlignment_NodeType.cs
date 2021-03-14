using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetBriefingAlignment_NodeType : questIUIManagerNodeType
	{
		private CEnum<questJournalAlignmentEventType> _briefingAlignment;

		[Ordinal(0)] 
		[RED("briefingAlignment")] 
		public CEnum<questJournalAlignmentEventType> BriefingAlignment
		{
			get
			{
				if (_briefingAlignment == null)
				{
					_briefingAlignment = (CEnum<questJournalAlignmentEventType>) CR2WTypeManager.Create("questJournalAlignmentEventType", "briefingAlignment", cr2w, this);
				}
				return _briefingAlignment;
			}
			set
			{
				if (_briefingAlignment == value)
				{
					return;
				}
				_briefingAlignment = value;
				PropertySet(this);
			}
		}

		public questSetBriefingAlignment_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
