using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkRadialWipeEffect : inkIEffect
	{
		[Ordinal(2)] 
		[RED("startAngle")] 
		public CFloat StartAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("transition")] 
		public CFloat Transition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkRadialWipeEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
