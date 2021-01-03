using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioSecurityTurretMetadata : audioCustomEmitterMetadata
	{
		[Ordinal(0)]  [RED("activated")] public CName Activated { get; set; }
		[Ordinal(1)]  [RED("deactivaed")] public CName Deactivaed { get; set; }
		[Ordinal(2)]  [RED("destroyed")] public CName Destroyed { get; set; }
		[Ordinal(3)]  [RED("idleStart")] public CName IdleStart { get; set; }
		[Ordinal(4)]  [RED("idleStop")] public CName IdleStop { get; set; }
		[Ordinal(5)]  [RED("obstructionEnabled")] public CBool ObstructionEnabled { get; set; }
		[Ordinal(6)]  [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
		[Ordinal(7)]  [RED("singleFire")] public CName SingleFire { get; set; }

		public audioSecurityTurretMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
