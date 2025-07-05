using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MineBarrageProjectile : BaseProjectile
	{
		[Ordinal(48)] 
		[RED("landIndicatorFX")] 
		public gameFxResource LandIndicatorFX
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(49)] 
		[RED("fxInstance")] 
		public CHandle<gameFxInstance> FxInstance
		{
			get => GetPropertyValue<CHandle<gameFxInstance>>();
			set => SetPropertyValue<CHandle<gameFxInstance>>(value);
		}

		[Ordinal(50)] 
		[RED("visualComponent")] 
		public CHandle<entMeshComponent> VisualComponent
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(51)] 
		[RED("onGround")] 
		public CBool OnGround
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("onGroundTimer")] 
		public CFloat OnGroundTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(54)] 
		[RED("attack_record")] 
		public CHandle<gamedataAttack_Record> Attack_record
		{
			get => GetPropertyValue<CHandle<gamedataAttack_Record>>();
			set => SetPropertyValue<CHandle<gamedataAttack_Record>>(value);
		}

		[Ordinal(55)] 
		[RED("detonationTimer")] 
		public CFloat DetonationTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("explosionRadius")] 
		public CFloat ExplosionRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("playerPuppet")] 
		public CWeakHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(58)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		public MineBarrageProjectile()
		{
			LandIndicatorFX = new gameFxResource();
			MappinID = new gameNewMappinID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
