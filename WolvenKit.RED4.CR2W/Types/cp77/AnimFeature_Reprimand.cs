using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Reprimand : animAnimFeature
	{
		private CInt32 _state;
		private CBool _isActive;
		private CBool _isLocomotion;
		private CInt32 _weaponType;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CInt32) CR2WTypeManager.Create("Int32", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isLocomotion")] 
		public CBool IsLocomotion
		{
			get
			{
				if (_isLocomotion == null)
				{
					_isLocomotion = (CBool) CR2WTypeManager.Create("Bool", "isLocomotion", cr2w, this);
				}
				return _isLocomotion;
			}
			set
			{
				if (_isLocomotion == value)
				{
					return;
				}
				_isLocomotion = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("weaponType")] 
		public CInt32 WeaponType
		{
			get
			{
				if (_weaponType == null)
				{
					_weaponType = (CInt32) CR2WTypeManager.Create("Int32", "weaponType", cr2w, this);
				}
				return _weaponType;
			}
			set
			{
				if (_weaponType == value)
				{
					return;
				}
				_weaponType = value;
				PropertySet(this);
			}
		}

		public AnimFeature_Reprimand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
