using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LightDirectionSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("direction")] public GlobalLightingTrajectoryOverride Direction { get; set; }

		public LightDirectionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
