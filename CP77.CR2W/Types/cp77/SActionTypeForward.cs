using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SActionTypeForward : CVariable
	{
		[Ordinal(0)]  [RED("master")] public CBool Master { get; set; }
		[Ordinal(1)]  [RED("qHack")] public CBool QHack { get; set; }
		[Ordinal(2)]  [RED("techie")] public CBool Techie { get; set; }

		public SActionTypeForward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
