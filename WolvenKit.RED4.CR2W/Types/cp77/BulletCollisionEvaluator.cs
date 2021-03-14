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
			get
			{
				if (_hasStopped == null)
				{
					_hasStopped = (CBool) CR2WTypeManager.Create("Bool", "hasStopped", cr2w, this);
				}
				return _hasStopped;
			}
			set
			{
				if (_hasStopped == value)
				{
					return;
				}
				_hasStopped = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stoppedPosition")] 
		public Vector4 StoppedPosition
		{
			get
			{
				if (_stoppedPosition == null)
				{
					_stoppedPosition = (Vector4) CR2WTypeManager.Create("Vector4", "stoppedPosition", cr2w, this);
				}
				return _stoppedPosition;
			}
			set
			{
				if (_stoppedPosition == value)
				{
					return;
				}
				_stoppedPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weaponParams")] 
		public gameprojectileWeaponParams WeaponParams
		{
			get
			{
				if (_weaponParams == null)
				{
					_weaponParams = (gameprojectileWeaponParams) CR2WTypeManager.Create("gameprojectileWeaponParams", "weaponParams", cr2w, this);
				}
				return _weaponParams;
			}
			set
			{
				if (_weaponParams == value)
				{
					return;
				}
				_weaponParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isExplodingBullet")] 
		public CBool IsExplodingBullet
		{
			get
			{
				if (_isExplodingBullet == null)
				{
					_isExplodingBullet = (CBool) CR2WTypeManager.Create("Bool", "isExplodingBullet", cr2w, this);
				}
				return _isExplodingBullet;
			}
			set
			{
				if (_isExplodingBullet == value)
				{
					return;
				}
				_isExplodingBullet = value;
				PropertySet(this);
			}
		}

		public BulletCollisionEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
