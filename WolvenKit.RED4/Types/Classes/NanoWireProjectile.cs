using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NanoWireProjectile : BaseProjectile
	{
		[Ordinal(48)] 
		[RED("maxAttackRange")] 
		public CFloat MaxAttackRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(49)] 
		[RED("launchMode")] 
		public CEnum<ELaunchMode> LaunchMode
		{
			get => GetPropertyValue<CEnum<ELaunchMode>>();
			set => SetPropertyValue<CEnum<ELaunchMode>>(value);
		}

		public NanoWireProjectile()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
