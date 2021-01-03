using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_WeightedQuat : ISerializable
	{
		[Ordinal(0)]  [RED("channel")] public CHandle<animIAnimNodeSourceChannel_Quat> Channel { get; set; }
		[Ordinal(1)]  [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(2)]  [RED("weightFloatTrack")] public animNamedTrackIndex WeightFloatTrack { get; set; }
		[Ordinal(3)]  [RED("weightLink")] public animFloatLink WeightLink { get; set; }

		public animAnimNodeSourceChannel_WeightedQuat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
