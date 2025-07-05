using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterLevelController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("playerSpawnPoint")] 
		public inkWidgetReference PlayerSpawnPoint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("collision")] 
		public inkWidgetReference Collision
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("levelType")] 
		public CEnum<gameuiarcadeShooterLevelType> LevelType
		{
			get => GetPropertyValue<CEnum<gameuiarcadeShooterLevelType>>();
			set => SetPropertyValue<CEnum<gameuiarcadeShooterLevelType>>(value);
		}

		[Ordinal(5)] 
		[RED("spawner")] 
		public inkWidgetReference Spawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("enemyBulletSpawner")] 
		public inkWidgetReference EnemyBulletSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("playerBulletSpawner")] 
		public inkWidgetReference PlayerBulletSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("vfxSpawner")] 
		public inkWidgetReference VfxSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("mapEndBorder")] 
		public Vector2 MapEndBorder
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public gameuiarcadeShooterLevelController()
		{
			PlayerSpawnPoint = new inkWidgetReference();
			Background = new inkWidgetReference();
			Collision = new inkWidgetReference();
			Spawner = new inkWidgetReference();
			EnemyBulletSpawner = new inkWidgetReference();
			PlayerBulletSpawner = new inkWidgetReference();
			VfxSpawner = new inkWidgetReference();
			MapEndBorder = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
