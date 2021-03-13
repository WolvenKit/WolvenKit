using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleNPCDeathData : animAnimFeature
	{
		[Ordinal(0)] [RED("deathType")] public CInt32 DeathType { get; set; }
		[Ordinal(1)] [RED("side")] public CInt32 Side { get; set; }

		public AnimFeature_VehicleNPCDeathData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
