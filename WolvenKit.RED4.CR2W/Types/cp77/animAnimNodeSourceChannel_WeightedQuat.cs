using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_WeightedQuat : ISerializable
	{
		[Ordinal(0)] [RED("channel")] public CHandle<animIAnimNodeSourceChannel_Quat> Channel { get; set; }
		[Ordinal(1)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(2)] [RED("weightLink")] public animFloatLink WeightLink { get; set; }
		[Ordinal(3)] [RED("weightFloatTrack")] public animNamedTrackIndex WeightFloatTrack { get; set; }

		public animAnimNodeSourceChannel_WeightedQuat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
