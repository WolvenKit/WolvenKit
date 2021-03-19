using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BulletCollisionEvaluator : gameprojectileScriptCollisionEvaluator
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

		public BulletCollisionEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
