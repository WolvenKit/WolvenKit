using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerColor : IParticleInitializer
	{
		[Ordinal(0)]  [RED("color")] public CHandle<IEvaluatorColor> Color { get; set; }

		public CParticleInitializerColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
