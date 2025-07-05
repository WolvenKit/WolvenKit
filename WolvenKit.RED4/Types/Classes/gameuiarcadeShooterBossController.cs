using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterBossController : gameuiarcadeShooterAIBase
	{
		[Ordinal(3)] 
		[RED("customBoundSize")] 
		public CBool CustomBoundSize
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("bossSize")] 
		public Vector2 BossSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public gameuiarcadeShooterBossController()
		{
			BossSize = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
