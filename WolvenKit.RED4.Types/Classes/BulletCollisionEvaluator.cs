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
			StoppedPosition = new();
			WeaponParams = new() { TargetPosition = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, SmartGunSpreadOnHitPlane = new(), SmartGunAccuracy = 1.000000F, SmartGunIsProjectileGuided = true, HitPlaneOffset = new(), IgnoreWeaponOwnerCollision = true, RicochetData = new(), Range = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
