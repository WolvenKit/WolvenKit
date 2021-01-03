using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HUDProgressBarData : CVariable
	{
		[Ordinal(0)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)]  [RED("header")] public CString Header { get; set; }
		[Ordinal(2)]  [RED("progress")] public CFloat Progress { get; set; }

		public HUDProgressBarData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
