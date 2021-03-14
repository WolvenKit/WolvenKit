using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetBriefingSize_NodeType : questIUIManagerNodeType
	{
		private CEnum<questJournalSizeEventType> _briefingSize;

		[Ordinal(0)] 
		[RED("briefingSize")] 
		public CEnum<questJournalSizeEventType> BriefingSize
		{
			get
			{
				if (_briefingSize == null)
				{
					_briefingSize = (CEnum<questJournalSizeEventType>) CR2WTypeManager.Create("questJournalSizeEventType", "briefingSize", cr2w, this);
				}
				return _briefingSize;
			}
			set
			{
				if (_briefingSize == value)
				{
					return;
				}
				_briefingSize = value;
				PropertySet(this);
			}
		}

		public questSetBriefingSize_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
