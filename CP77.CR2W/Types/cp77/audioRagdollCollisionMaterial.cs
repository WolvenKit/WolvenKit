using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioRagdollCollisionMaterial : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("dismemberedLimbCollisionEventName")] public CName DismemberedLimbCollisionEventName { get; set; }
		[Ordinal(1)]  [RED("heavyCollisionEventName")] public CName HeavyCollisionEventName { get; set; }
		[Ordinal(2)]  [RED("lightCollisionEventName")] public CName LightCollisionEventName { get; set; }

		public audioRagdollCollisionMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
