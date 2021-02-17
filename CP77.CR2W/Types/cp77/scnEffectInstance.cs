using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnEffectInstance : CVariable
	{
		[Ordinal(0)] [RED("effectInstanceId")] public scnEffectInstanceId EffectInstanceId { get; set; }
		[Ordinal(1)] [RED("compiledEffect")] public worldCompiledEffectInfo CompiledEffect { get; set; }

		public scnEffectInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
