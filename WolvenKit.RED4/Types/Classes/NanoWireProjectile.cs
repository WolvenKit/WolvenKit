using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NanoWireProjectile : BaseProjectile
	{
		[Ordinal(46)] 
		[RED("maxAttackRange")] 
		public CFloat MaxAttackRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
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
