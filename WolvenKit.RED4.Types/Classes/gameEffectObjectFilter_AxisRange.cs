using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_AxisRange : gameEffectObjectSingleFilter
	{
		[Ordinal(0)] 
		[RED("axis")] 
		public CEnum<gameEffectObjectFilter_AxisRangeAxis> Axis
		{
			get => GetPropertyValue<CEnum<gameEffectObjectFilter_AxisRangeAxis>>();
			set => SetPropertyValue<CEnum<gameEffectObjectFilter_AxisRangeAxis>>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public gameEffectInputParameter_Vector Position
		{
			get => GetPropertyValue<gameEffectInputParameter_Vector>();
			set => SetPropertyValue<gameEffectInputParameter_Vector>(value);
		}

		[Ordinal(2)] 
		[RED("constraints")] 
		public gameEffectInputParameter_Vector Constraints
		{
			get => GetPropertyValue<gameEffectInputParameter_Vector>();
			set => SetPropertyValue<gameEffectInputParameter_Vector>(value);
		}

		public gameEffectObjectFilter_AxisRange()
		{
			Position = new();
			Constraints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
