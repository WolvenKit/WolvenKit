using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioRagdollCollisionMaterial : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("lightCollisionEventName")] public CName LightCollisionEventName { get; set; }
		[Ordinal(1)]  [RED("heavyCollisionEventName")] public CName HeavyCollisionEventName { get; set; }
		[Ordinal(2)]  [RED("dismemberedLimbCollisionEventName")] public CName DismemberedLimbCollisionEventName { get; set; }

		public audioRagdollCollisionMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
