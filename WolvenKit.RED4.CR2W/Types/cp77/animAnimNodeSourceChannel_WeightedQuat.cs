using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_WeightedQuat : ISerializable
	{
		private CHandle<animIAnimNodeSourceChannel_Quat> _channel;
		private CFloat _weight;
		private animFloatLink _weightLink;
		private animNamedTrackIndex _weightFloatTrack;

		[Ordinal(0)] 
		[RED("channel")] 
		public CHandle<animIAnimNodeSourceChannel_Quat> Channel
		{
			get => GetProperty(ref _channel);
			set => SetProperty(ref _channel, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(2)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get => GetProperty(ref _weightLink);
			set => SetProperty(ref _weightLink, value);
		}

		[Ordinal(3)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetProperty(ref _weightFloatTrack);
			set => SetProperty(ref _weightFloatTrack, value);
		}

		public animAnimNodeSourceChannel_WeightedQuat(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
