using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FloatRandom : animAnimNode_FloatValue
	{
		private CBool _rand;
		private CFloat _cooldown;
		private CFloat _min;
		private CFloat _max;

		[Ordinal(11)] 
		[RED("rand")] 
		public CBool Rand
		{
			get => GetProperty(ref _rand);
			set => SetProperty(ref _rand, value);
		}

		[Ordinal(12)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(13)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(14)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}
	}
}
