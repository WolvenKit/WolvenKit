using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnEffectInstance : CVariable
	{
		[Ordinal(0)]  [RED("compiledEffect")] public worldCompiledEffectInfo CompiledEffect { get; set; }
		[Ordinal(1)]  [RED("effectInstanceId")] public scnEffectInstanceId EffectInstanceId { get; set; }

		public scnEffectInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
