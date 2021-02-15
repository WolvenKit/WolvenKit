using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TonemappingAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("mode")] public CHandle<ITonemappingMode> Mode { get; set; }
		[Ordinal(3)] [RED("hdrMode")] public CHandle<ITonemappingMode> HdrMode { get; set; }

		public TonemappingAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
