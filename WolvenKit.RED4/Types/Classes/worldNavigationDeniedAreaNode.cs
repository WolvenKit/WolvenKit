using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationDeniedAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("human")] 
		public CBool Human
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("vehicle")] 
		public CBool Vehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldNavigationDeniedAreaNode()
		{
			Human = true;
			Vehicle = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
