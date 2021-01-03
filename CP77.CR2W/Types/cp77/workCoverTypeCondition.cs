using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workCoverTypeCondition : workIWorkspotCondition
	{
		[Ordinal(0)]  [RED("isHighCover")] public CBool IsHighCover { get; set; }

		public workCoverTypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
