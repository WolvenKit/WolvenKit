using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BulletCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		[Ordinal(0)] 
		[RED("hasStopped")] 
		public CBool HasStopped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("stoppedPosition")] 
		public Vector4 StoppedPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("weaponParams")] 
		public gameprojectileWeaponParams WeaponParams
		{
			get => GetPropertyValue<gameprojectileWeaponParams>();
			set => SetPropertyValue<gameprojectileWeaponParams>(value);
		}

		[Ordinal(3)] 
		[RED("isExplodingBullet")] 
		public CBool IsExplodingBullet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BulletCollisionEvaluator()
		{
			StoppedPosition = new Vector4();
			WeaponParams = new gameprojectileWeaponParams { TargetPosition = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, SmartGunSpreadOnHitPlane = new Vector3(), SmartGunAccuracy = 1.000000F, SmartGunIsProjectileGuided = true, HitPlaneOffset = new Vector4(), IgnoreWeaponOwnerCollision = true, RicochetData = new gameRicochetData(), Range = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
