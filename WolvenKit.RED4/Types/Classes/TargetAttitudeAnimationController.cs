using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetAttitudeAnimationController : BasicAnimationController
	{
		[Ordinal(6)] 
		[RED("hostileShowAnimation")] 
		public CName HostileShowAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("hostileIdleAnimation")] 
		public CName HostileIdleAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("hostileHideAnimation")] 
		public CName HostileHideAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetPropertyValue<CEnum<EAIAttitude>>();
			set => SetPropertyValue<CEnum<EAIAttitude>>(value);
		}

		public TargetAttitudeAnimationController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
