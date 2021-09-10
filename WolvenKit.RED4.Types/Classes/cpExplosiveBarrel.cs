using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpExplosiveBarrel : gameDestructibleObject
	{
		[Ordinal(41)] 
		[RED("colliderComponentName")] 
		public CName ColliderComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(42)] 
		[RED("destructionComponentName")] 
		public CName DestructionComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
