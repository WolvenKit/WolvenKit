using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StrikeExecutor_Heal : gameEffectExecutor_Scripted
	{
		[Ordinal(0)]  [RED("healthPerc")] public CFloat HealthPerc { get; set; }

		public StrikeExecutor_Heal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
