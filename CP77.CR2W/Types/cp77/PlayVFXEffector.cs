using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayVFXEffector : gameEffector
	{
		[Ordinal(0)]  [RED("fireAndForget")] public CBool FireAndForget { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)]  [RED("startOnUninitialize")] public CBool StartOnUninitialize { get; set; }
		[Ordinal(3)]  [RED("vfxName")] public CName VfxName { get; set; }

		public PlayVFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
