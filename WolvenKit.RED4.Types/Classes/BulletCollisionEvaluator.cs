using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BulletCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		private CBool _hasStopped;
		private Vector4 _stoppedPosition;
		private gameprojectileWeaponParams _weaponParams;
		private CBool _isExplodingBullet;

		[Ordinal(0)] 
		[RED("hasStopped")] 
		public CBool HasStopped
		{
			get => GetProperty(ref _hasStopped);
			set => SetProperty(ref _hasStopped, value);
		}

		[Ordinal(1)] 
		[RED("stoppedPosition")] 
		public Vector4 StoppedPosition
		{
			get => GetProperty(ref _stoppedPosition);
			set => SetProperty(ref _stoppedPosition, value);
		}

		[Ordinal(2)] 
		[RED("weaponParams")] 
		public gameprojectileWeaponParams WeaponParams
		{
			get => GetProperty(ref _weaponParams);
			set => SetProperty(ref _weaponParams, value);
		}

		[Ordinal(3)] 
		[RED("isExplodingBullet")] 
		public CBool IsExplodingBullet
		{
			get => GetProperty(ref _isExplodingBullet);
			set => SetProperty(ref _isExplodingBullet, value);
		}
	}
}
