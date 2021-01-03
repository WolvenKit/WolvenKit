using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EmitterGroupAreaParams : CVariable
	{
		[Ordinal(0)]  [RED("emissionScale")] public curveData<CFloat> EmissionScale { get; set; }
		[Ordinal(1)]  [RED("group")] public CEnum<EEmitterGroup> Group { get; set; }
		[Ordinal(2)]  [RED("opacityScale")] public curveData<CFloat> OpacityScale { get; set; }

		public EmitterGroupAreaParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
