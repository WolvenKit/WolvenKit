using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerColor : IParticleInitializer
	{
		[Ordinal(0)]  [RED("color")] public CHandle<IEvaluatorColor> Color { get; set; }

		public CParticleInitializerColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
