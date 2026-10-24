using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationDeniedAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("human")] 
		public CBool Human
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("vehicle")] 
		public CBool Vehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldNavigationDeniedAreaNode()
		{
			Color = new CColor { Red = 255, Green = 178, Blue = 102, Alpha = 120 };
			Human = true;
			Vehicle = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
