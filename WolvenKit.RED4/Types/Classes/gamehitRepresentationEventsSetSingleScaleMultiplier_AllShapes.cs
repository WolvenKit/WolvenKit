using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes : redEvent
	{
		[Ordinal(0)] 
		[RED("scaleMultiplier")] 
		public Vector4 ScaleMultiplier
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes()
		{
			ScaleMultiplier = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
