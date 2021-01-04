using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_OverrideMaterial : gameEffectExecutor
	{
		[Ordinal(0)]  [RED("material")] public rRef<IMaterial> Material { get; set; }

		public gameEffectExecutor_OverrideMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
