using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkanimEffectInterpolator : inkanimInterpolator
	{
		[Ordinal(0)]  [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(1)]  [RED("effectType")] public CEnum<inkEffectType> EffectType { get; set; }
		[Ordinal(2)]  [RED("endValue")] public CFloat EndValue { get; set; }
		[Ordinal(3)]  [RED("paramName")] public CName ParamName { get; set; }
		[Ordinal(4)]  [RED("startValue")] public CFloat StartValue { get; set; }

		public inkanimEffectInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
