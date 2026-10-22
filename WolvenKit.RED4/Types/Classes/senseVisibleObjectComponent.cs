using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseVisibleObjectComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("visibleObject")] 
		public CHandle<senseVisibleObject> VisibleObject
		{
			get => GetPropertyValue<CHandle<senseVisibleObject>>();
			set => SetPropertyValue<CHandle<senseVisibleObject>>(value);
		}

		public senseVisibleObjectComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
