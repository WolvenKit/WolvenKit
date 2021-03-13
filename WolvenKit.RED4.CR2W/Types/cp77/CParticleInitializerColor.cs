using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerColor : IParticleInitializer
	{
		[Ordinal(4)] [RED("color")] public CHandle<IEvaluatorColor> Color { get; set; }

		public CParticleInitializerColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
