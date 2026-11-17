using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinfluenceComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameinfluenceComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
