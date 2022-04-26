using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldRaceSplineNode : worldSpeedSplineNode
	{
		[Ordinal(17)] 
		[RED("offsets")] 
		public CArray<worldRaceSplineNodeOffset> Offsets
		{
			get => GetPropertyValue<CArray<worldRaceSplineNodeOffset>>();
			set => SetPropertyValue<CArray<worldRaceSplineNodeOffset>>(value);
		}

		[Ordinal(18)] 
		[RED("offsetDefault")] 
		public CFloat OffsetDefault
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldRaceSplineNode()
		{
			Offsets = new();
			OffsetDefault = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
