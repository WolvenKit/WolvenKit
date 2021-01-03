using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TonemappingAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("hdrMode")] public CHandle<ITonemappingMode> HdrMode { get; set; }
		[Ordinal(1)]  [RED("mode")] public CHandle<ITonemappingMode> Mode { get; set; }

		public TonemappingAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
