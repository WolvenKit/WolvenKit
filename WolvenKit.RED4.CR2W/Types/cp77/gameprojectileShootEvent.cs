using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileShootEvent : gameprojectileSetUpEvent
	{
		private CMatrix _localToWorld;
		private Vector4 _startPoint;
		private Vector4 _startVelocity;
		private Vector4 _weaponVelocity;
		private gameprojectileWeaponParams _params;

		[Ordinal(4)] 
		[RED("localToWorld")] 
		public CMatrix LocalToWorld
		{
			get
			{
				if (_localToWorld == null)
				{
					_localToWorld = (CMatrix) CR2WTypeManager.Create("Matrix", "localToWorld", cr2w, this);
				}
				return _localToWorld;
			}
			set
			{
				if (_localToWorld == value)
				{
					return;
				}
				_localToWorld = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("startPoint")] 
		public Vector4 StartPoint
		{
			get
			{
				if (_startPoint == null)
				{
					_startPoint = (Vector4) CR2WTypeManager.Create("Vector4", "startPoint", cr2w, this);
				}
				return _startPoint;
			}
			set
			{
				if (_startPoint == value)
				{
					return;
				}
				_startPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("startVelocity")] 
		public Vector4 StartVelocity
		{
			get
			{
				if (_startVelocity == null)
				{
					_startVelocity = (Vector4) CR2WTypeManager.Create("Vector4", "startVelocity", cr2w, this);
				}
				return _startVelocity;
			}
			set
			{
				if (_startVelocity == value)
				{
					return;
				}
				_startVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("weaponVelocity")] 
		public Vector4 WeaponVelocity
		{
			get
			{
				if (_weaponVelocity == null)
				{
					_weaponVelocity = (Vector4) CR2WTypeManager.Create("Vector4", "weaponVelocity", cr2w, this);
				}
				return _weaponVelocity;
			}
			set
			{
				if (_weaponVelocity == value)
				{
					return;
				}
				_weaponVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("params")] 
		public gameprojectileWeaponParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (gameprojectileWeaponParams) CR2WTypeManager.Create("gameprojectileWeaponParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public gameprojectileShootEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
