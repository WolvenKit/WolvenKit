using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioNpcGunChoirVoice : audioAudioMetadata
	{
		private CName _fireSound;
		private CName _burstFireSound;
		private CName _chargedSound;
		private CName _autoFireSound;
		private CName _autoFireStop;
		private CName _shutdown;
		private CName _init;

		[Ordinal(1)] 
		[RED("fireSound")] 
		public CName FireSound
		{
			get => GetProperty(ref _fireSound);
			set => SetProperty(ref _fireSound, value);
		}

		[Ordinal(2)] 
		[RED("burstFireSound")] 
		public CName BurstFireSound
		{
			get => GetProperty(ref _burstFireSound);
			set => SetProperty(ref _burstFireSound, value);
		}

		[Ordinal(3)] 
		[RED("chargedSound")] 
		public CName ChargedSound
		{
			get => GetProperty(ref _chargedSound);
			set => SetProperty(ref _chargedSound, value);
		}

		[Ordinal(4)] 
		[RED("autoFireSound")] 
		public CName AutoFireSound
		{
			get => GetProperty(ref _autoFireSound);
			set => SetProperty(ref _autoFireSound, value);
		}

		[Ordinal(5)] 
		[RED("autoFireStop")] 
		public CName AutoFireStop
		{
			get => GetProperty(ref _autoFireStop);
			set => SetProperty(ref _autoFireStop, value);
		}

		[Ordinal(6)] 
		[RED("shutdown")] 
		public CName Shutdown
		{
			get => GetProperty(ref _shutdown);
			set => SetProperty(ref _shutdown, value);
		}

		[Ordinal(7)] 
		[RED("init")] 
		public CName Init
		{
			get => GetProperty(ref _init);
			set => SetProperty(ref _init, value);
		}

		public audioNpcGunChoirVoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
