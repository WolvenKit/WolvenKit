using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CandleControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("candleSkillChecks")] public CHandle<EngDemoContainer> CandleSkillChecks { get; set; }

		public CandleControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
