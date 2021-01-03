using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickhackInstance : ModuleInstance
	{
		[Ordinal(0)]  [RED("open")] public CBool Open { get; set; }
		[Ordinal(1)]  [RED("process")] public CBool Process { get; set; }

		public QuickhackInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
