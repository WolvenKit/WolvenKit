using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLinearWipeEffect : inkIEffect
	{
		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
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

		public inkLinearWipeEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
