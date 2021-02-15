using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EmitterGroupAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("emitterGroupParams")] public CArray<EmitterGroupParams> EmitterGroupParams_72 { get; set; }
		[Ordinal(3)] [RED("EmitterGroupParams")] public CArray<EmitterGroupAreaParams> EmitterGroupParams_88 { get; set; }

		public EmitterGroupAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
