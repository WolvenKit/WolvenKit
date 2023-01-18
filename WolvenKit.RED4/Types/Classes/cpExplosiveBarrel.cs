using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpExplosiveBarrel : gameDestructibleObject
	{
		[Ordinal(36)] 
		[RED("colliderComponentName")] 
		public CName ColliderComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("destructionComponentName")] 
		public CName DestructionComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public cpExplosiveBarrel()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
