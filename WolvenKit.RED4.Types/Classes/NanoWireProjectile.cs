using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NanoWireProjectile : BaseProjectile
	{
		private CFloat _maxAttackRange;
		private CEnum<ELaunchMode> _launchMode;

		[Ordinal(51)] 
		[RED("maxAttackRange")] 
		public CFloat MaxAttackRange
		{
			get => GetProperty(ref _maxAttackRange);
			set => SetProperty(ref _maxAttackRange, value);
		}

		[Ordinal(52)] 
		[RED("launchMode")] 
		public CEnum<ELaunchMode> LaunchMode
		{
			get => GetProperty(ref _launchMode);
			set => SetProperty(ref _launchMode, value);
		}
	}
}
