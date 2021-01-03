using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AmbientOverrideAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("color")] public [6]curveData<HDRColor> Color { get; set; }

		public AmbientOverrideAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
