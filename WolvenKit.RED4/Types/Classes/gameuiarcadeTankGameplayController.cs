using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeTankGameplayController : gameuiarcadeArcadeGameplayController
	{
		[Ordinal(3)] 
		[RED("player")] 
		public inkWidgetReference Player
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("enemySpawner")] 
		public inkWidgetReference EnemySpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("obstacleSpawner")] 
		public inkWidgetReference ObstacleSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("pickupSpawner")] 
		public inkWidgetReference PickupSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("projectileSpawner")] 
		public inkWidgetReference ProjectileSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("hudCounter")] 
		public inkWidgetReference HudCounter
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("hudScoreMultiplier")] 
		public inkWidgetReference HudScoreMultiplier
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeTankGameplayController()
		{
			Score = new inkWidgetReference();
			PauseText = new inkWidgetReference();
			Player = new inkWidgetReference();
			EnemySpawner = new inkWidgetReference();
			ObstacleSpawner = new inkWidgetReference();
			PickupSpawner = new inkWidgetReference();
			ProjectileSpawner = new inkWidgetReference();
			Background = new inkWidgetReference();
			HudCounter = new inkWidgetReference();
			HudScoreMultiplier = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
