using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrossingLight : TrafficLight
	{
		[Ordinal(89)] [RED("audioLightIsGreen")] public CBool AudioLightIsGreen { get; set; }

		public CrossingLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
