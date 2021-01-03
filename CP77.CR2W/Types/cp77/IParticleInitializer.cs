using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IParticleInitializer : IParticleModule
	{
		[Ordinal(0)]  [RED("seed")] public CUInt32 Seed { get; set; }

		public IParticleInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
