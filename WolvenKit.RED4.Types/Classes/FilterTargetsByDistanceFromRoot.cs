using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FilterTargetsByDistanceFromRoot : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)] 
		[RED("rootOffset_Z")] 
		public CFloat RootOffset_Z
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("tollerance")] 
		public CFloat Tollerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public FilterTargetsByDistanceFromRoot()
		{
			RootOffset_Z = 1.000000F;
			Tollerance = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
