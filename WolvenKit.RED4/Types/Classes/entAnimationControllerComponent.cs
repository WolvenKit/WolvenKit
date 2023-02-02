using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimationControllerComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("actionAnimDatabaseRef")] 
		public CResourceReference<animActionAnimDatabase> ActionAnimDatabaseRef
		{
			get => GetPropertyValue<CResourceReference<animActionAnimDatabase>>();
			set => SetPropertyValue<CResourceReference<animActionAnimDatabase>>(value);
		}

		[Ordinal(4)] 
		[RED("animDatabaseCollection")] 
		public animAnimDatabaseCollection AnimDatabaseCollection
		{
			get => GetPropertyValue<animAnimDatabaseCollection>();
			set => SetPropertyValue<animAnimDatabaseCollection>(value);
		}

		[Ordinal(5)] 
		[RED("controlBinding")] 
		public CHandle<entAnimationControlBinding> ControlBinding
		{
			get => GetPropertyValue<CHandle<entAnimationControlBinding>>();
			set => SetPropertyValue<CHandle<entAnimationControlBinding>>(value);
		}

		public entAnimationControllerComponent()
		{
			Name = "Component";
			AnimDatabaseCollection = new() { AnimDatabases = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
