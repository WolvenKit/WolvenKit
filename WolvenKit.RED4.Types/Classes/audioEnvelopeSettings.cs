using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEnvelopeSettings : audioAudioMetadata
	{
		private CFloat _attackTime;
		private CFloat _releaseTime;
		private CFloat _holdTime;

		[Ordinal(1)] 
		[RED("attackTime")] 
		public CFloat AttackTime
		{
			get => GetProperty(ref _attackTime);
			set => SetProperty(ref _attackTime, value);
		}

		[Ordinal(2)] 
		[RED("releaseTime")] 
		public CFloat ReleaseTime
		{
			get => GetProperty(ref _releaseTime);
			set => SetProperty(ref _releaseTime, value);
		}

		[Ordinal(3)] 
		[RED("holdTime")] 
		public CFloat HoldTime
		{
			get => GetProperty(ref _holdTime);
			set => SetProperty(ref _holdTime, value);
		}
	}
}
