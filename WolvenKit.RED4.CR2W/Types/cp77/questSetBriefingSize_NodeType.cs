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
			get => GetProperty(ref _briefingSize);
			set => SetProperty(ref _briefingSize, value);
		}

		public questSetBriefingSize_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
