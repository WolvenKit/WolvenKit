using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape : gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes
	{
		[Ordinal(1)] 
		[RED("shapeName")] 
		public CName ShapeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
