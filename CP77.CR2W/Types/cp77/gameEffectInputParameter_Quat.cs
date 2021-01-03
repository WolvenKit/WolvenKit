using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectInputParameter_Quat : CVariable
	{
		[Ordinal(0)]  [RED("evaluator")] public CHandle<gameIEffectParameter_QuatEvaluator> Evaluator { get; set; }

		public gameEffectInputParameter_Quat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
