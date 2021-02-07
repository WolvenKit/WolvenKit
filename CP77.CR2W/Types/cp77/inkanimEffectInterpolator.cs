using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimEffectInterpolator : inkanimInterpolator
	{
		[Ordinal(0)]  [RED("startValue")] public CFloat StartValue { get; set; }
		[Ordinal(1)]  [RED("endValue")] public CFloat EndValue { get; set; }
		[Ordinal(2)]  [RED("effectType")] public CEnum<inkEffectType> EffectType { get; set; }
		[Ordinal(3)]  [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(4)]  [RED("paramName")] public CName ParamName { get; set; }

		public inkanimEffectInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
