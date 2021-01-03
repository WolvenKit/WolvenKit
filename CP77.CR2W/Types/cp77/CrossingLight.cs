using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CrossingLight : TrafficLight
	{
		[Ordinal(0)]  [RED("audioLightIsGreen")] public CBool AudioLightIsGreen { get; set; }

		public CrossingLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
