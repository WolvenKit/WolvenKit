using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StopAndPlaySFXEffector : gameEffector
	{
		[Ordinal(0)] [RED("sfxToStop")] public CName SfxToStop { get; set; }
		[Ordinal(1)] [RED("sfxToStart")] public CName SfxToStart { get; set; }
		[Ordinal(2)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public StopAndPlaySFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
