using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSetUpEvent : redEvent
	{
		private wCHandle<gameObject> _owner;
		private wCHandle<gameObject> _weapon;
		private CHandle<gameprojectileTrajectoryParams> _trajectoryParams;
		private CFloat _lerpMultiplier;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weapon")] 
		public wCHandle<gameObject> Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("trajectoryParams")] 
		public CHandle<gameprojectileTrajectoryParams> TrajectoryParams
		{
			get
			{
				if (_trajectoryParams == null)
				{
					_trajectoryParams = (CHandle<gameprojectileTrajectoryParams>) CR2WTypeManager.Create("handle:gameprojectileTrajectoryParams", "trajectoryParams", cr2w, this);
				}
				return _trajectoryParams;
			}
			set
			{
				if (_trajectoryParams == value)
				{
					return;
				}
				_trajectoryParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lerpMultiplier")] 
		public CFloat LerpMultiplier
		{
			get
			{
				if (_lerpMultiplier == null)
				{
					_lerpMultiplier = (CFloat) CR2WTypeManager.Create("Float", "lerpMultiplier", cr2w, this);
				}
				return _lerpMultiplier;
			}
			set
			{
				if (_lerpMultiplier == value)
				{
					return;
				}
				_lerpMultiplier = value;
				PropertySet(this);
			}
		}

		public gameprojectileSetUpEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
