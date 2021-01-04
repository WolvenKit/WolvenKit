using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StopAndPlayVFXEffector : gameEffector
	{
		[Ordinal(0)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)]  [RED("vfxToStart")] public CName VfxToStart { get; set; }
		[Ordinal(2)]  [RED("vfxToStop")] public CName VfxToStop { get; set; }

		public StopAndPlayVFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
