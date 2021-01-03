using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EmitterGroupParams : CVariable
	{
		[Ordinal(0)]  [RED("emissionScale")] public CFloat EmissionScale { get; set; }
		[Ordinal(1)]  [RED("group")] public CEnum<EEmitterGroup> Group { get; set; }
		[Ordinal(2)]  [RED("opacityScale")] public CFloat OpacityScale { get; set; }

		public EmitterGroupParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
