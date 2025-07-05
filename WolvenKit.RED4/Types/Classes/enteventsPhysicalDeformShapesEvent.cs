using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class enteventsPhysicalDeformShapesEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("shapes")] 
		public CArray<CInt32> Shapes
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public enteventsPhysicalDeformShapesEvent()
		{
			Shapes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
