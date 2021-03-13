using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhackInstance : ModuleInstance
	{
		[Ordinal(6)] [RED("open")] public CBool Open { get; set; }
		[Ordinal(7)] [RED("process")] public CBool Process { get; set; }

		public QuickhackInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
