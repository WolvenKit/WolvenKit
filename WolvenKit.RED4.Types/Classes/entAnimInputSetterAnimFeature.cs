using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimInputSetterAnimFeature : entAnimInputSetter
	{
		private CHandle<animAnimFeature> _value;
		private CFloat _delay;

		[Ordinal(1)] 
		[RED("value")] 
		public CHandle<animAnimFeature> Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}
	}
}
