using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Target : IScriptable
	{
		[Ordinal(0)]  [RED("isInteresting")] public CBool IsInteresting { get; set; }
		[Ordinal(1)]  [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(2)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public Target(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
