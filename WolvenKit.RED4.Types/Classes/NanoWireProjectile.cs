using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NanoWireProjectile : BaseProjectile
	{
		[Ordinal(51)] 
		[RED("maxAttackRange")] 
		public CFloat MaxAttackRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("launchMode")] 
		public CEnum<ELaunchMode> LaunchMode
		{
			get => GetPropertyValue<CEnum<ELaunchMode>>();
			set => SetPropertyValue<CEnum<ELaunchMode>>(value);
		}
	}
}
