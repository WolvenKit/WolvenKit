using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGearSweetener : audioAudioMetadata
	{
		private CUInt32 _gear;
		private CFloat _rpmThreshold;
		private CFloat _cooldown;
		private CName _soundEvent;
		private CFloat _burnoutFactor;

		[Ordinal(1)] 
		[RED("gear")] 
		public CUInt32 Gear
		{
			get => GetProperty(ref _gear);
			set => SetProperty(ref _gear, value);
		}

		[Ordinal(2)] 
		[RED("rpmThreshold")] 
		public CFloat RpmThreshold
		{
			get => GetProperty(ref _rpmThreshold);
			set => SetProperty(ref _rpmThreshold, value);
		}

		[Ordinal(3)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(4)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get => GetProperty(ref _soundEvent);
			set => SetProperty(ref _soundEvent, value);
		}

		[Ordinal(5)] 
		[RED("burnoutFactor")] 
		public CFloat BurnoutFactor
		{
			get => GetProperty(ref _burnoutFactor);
			set => SetProperty(ref _burnoutFactor, value);
		}

		public audioGearSweetener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
