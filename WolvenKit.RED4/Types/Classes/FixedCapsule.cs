using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class FixedCapsule : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("PointRadius")] 
		public Vector4 PointRadius
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("Height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public FixedCapsule()
		{
			PointRadius = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
