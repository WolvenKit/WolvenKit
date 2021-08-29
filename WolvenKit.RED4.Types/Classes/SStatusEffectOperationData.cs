using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SStatusEffectOperationData : RedBaseClass
	{
		private CFloat _range;
		private CFloat _duration;
		private Vector4 _offset;
		private gameStatusEffectTDBPicker _effect;

		[Ordinal(0)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector4 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(3)] 
		[RED("effect")] 
		public gameStatusEffectTDBPicker Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}
	}
}
