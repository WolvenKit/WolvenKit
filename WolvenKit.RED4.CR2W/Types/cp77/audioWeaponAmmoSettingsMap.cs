using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponAmmoSettingsMap : audioAudioMetadata
	{
		private audioFlybySettings _standardFlyby;
		private audioFlybySettings _sniperFlyby;
		private audioFlybySettings _shotFlyby;
		private audioFlybySettings _railFlyby;
		private audioFlybySettings _automaticFlyby;
		private audioFlybySettings _smartFlyby;
		private audioFlybySettings _smartSniperFlyby;
		private audioFlybySettings _hmgFlyby;
		private CFloat _flybyMinDistance;

		[Ordinal(1)] 
		[RED("standardFlyby")] 
		public audioFlybySettings StandardFlyby
		{
			get => GetProperty(ref _standardFlyby);
			set => SetProperty(ref _standardFlyby, value);
		}

		[Ordinal(2)] 
		[RED("sniperFlyby")] 
		public audioFlybySettings SniperFlyby
		{
			get => GetProperty(ref _sniperFlyby);
			set => SetProperty(ref _sniperFlyby, value);
		}

		[Ordinal(3)] 
		[RED("shotFlyby")] 
		public audioFlybySettings ShotFlyby
		{
			get => GetProperty(ref _shotFlyby);
			set => SetProperty(ref _shotFlyby, value);
		}

		[Ordinal(4)] 
		[RED("railFlyby")] 
		public audioFlybySettings RailFlyby
		{
			get => GetProperty(ref _railFlyby);
			set => SetProperty(ref _railFlyby, value);
		}

		[Ordinal(5)] 
		[RED("automaticFlyby")] 
		public audioFlybySettings AutomaticFlyby
		{
			get => GetProperty(ref _automaticFlyby);
			set => SetProperty(ref _automaticFlyby, value);
		}

		[Ordinal(6)] 
		[RED("smartFlyby")] 
		public audioFlybySettings SmartFlyby
		{
			get => GetProperty(ref _smartFlyby);
			set => SetProperty(ref _smartFlyby, value);
		}

		[Ordinal(7)] 
		[RED("smartSniperFlyby")] 
		public audioFlybySettings SmartSniperFlyby
		{
			get => GetProperty(ref _smartSniperFlyby);
			set => SetProperty(ref _smartSniperFlyby, value);
		}

		[Ordinal(8)] 
		[RED("hmgFlyby")] 
		public audioFlybySettings HmgFlyby
		{
			get => GetProperty(ref _hmgFlyby);
			set => SetProperty(ref _hmgFlyby, value);
		}

		[Ordinal(9)] 
		[RED("flybyMinDistance")] 
		public CFloat FlybyMinDistance
		{
			get => GetProperty(ref _flybyMinDistance);
			set => SetProperty(ref _flybyMinDistance, value);
		}

		public audioWeaponAmmoSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
