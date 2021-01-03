using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animDyngParticlesContainer : CVariable
	{
		[Ordinal(0)]  [RED("externalForceWS")] public Vector3 ExternalForceWS { get; set; }
		[Ordinal(1)]  [RED("externalForceWsLink")] public animVectorLink ExternalForceWsLink { get; set; }
		[Ordinal(2)]  [RED("gravityWS")] public CFloat GravityWS { get; set; }
		[Ordinal(3)]  [RED("particles")] public CArray<animDyngParticle> Particles { get; set; }

		public animDyngParticlesContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
