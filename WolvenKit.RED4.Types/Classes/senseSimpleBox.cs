using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseSimpleBox : senseIShape
	{
		[Ordinal(1)] 
		[RED("box")] 
		public Box Box
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		public senseSimpleBox()
		{
			Box = new() { Min = new(), Max = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
