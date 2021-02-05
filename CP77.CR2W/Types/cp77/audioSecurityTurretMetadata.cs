using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioSecurityTurretMetadata : audioCustomEmitterMetadata
	{
		[Ordinal(0)]  [RED("singleFire")] public CName SingleFire { get; set; }
		[Ordinal(1)]  [RED("activated")] public CName Activated { get; set; }
		[Ordinal(2)]  [RED("deactivaed")] public CName Deactivaed { get; set; }
		[Ordinal(3)]  [RED("destroyed")] public CName Destroyed { get; set; }
		[Ordinal(4)]  [RED("idleStart")] public CName IdleStart { get; set; }
		[Ordinal(5)]  [RED("idleStop")] public CName IdleStop { get; set; }
		[Ordinal(6)]  [RED("obstructionEnabled")] public CBool ObstructionEnabled { get; set; }
		[Ordinal(7)]  [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }

		public audioSecurityTurretMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
