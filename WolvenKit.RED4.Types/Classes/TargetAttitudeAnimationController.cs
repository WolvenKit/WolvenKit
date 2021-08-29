using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetAttitudeAnimationController : BasicAnimationController
	{
		private CName _hostileShowAnimation;
		private CName _hostileIdleAnimation;
		private CName _hostileHideAnimation;
		private CEnum<EAIAttitude> _attitude;

		[Ordinal(6)] 
		[RED("hostileShowAnimation")] 
		public CName HostileShowAnimation
		{
			get => GetProperty(ref _hostileShowAnimation);
			set => SetProperty(ref _hostileShowAnimation, value);
		}

		[Ordinal(7)] 
		[RED("hostileIdleAnimation")] 
		public CName HostileIdleAnimation
		{
			get => GetProperty(ref _hostileIdleAnimation);
			set => SetProperty(ref _hostileIdleAnimation, value);
		}

		[Ordinal(8)] 
		[RED("hostileHideAnimation")] 
		public CName HostileHideAnimation
		{
			get => GetProperty(ref _hostileHideAnimation);
			set => SetProperty(ref _hostileHideAnimation, value);
		}

		[Ordinal(9)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}
	}
}
