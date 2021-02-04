using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EmitterGroupAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("emitterGroupParams")] public CArray<EmitterGroupParams> EmitterGroupParams { get; set; }
		[Ordinal(1)]  [RED("EmitterGroupParams")] public CArray<EmitterGroupAreaParams> _EmitterGroupParams { get; set; }

		public EmitterGroupAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
