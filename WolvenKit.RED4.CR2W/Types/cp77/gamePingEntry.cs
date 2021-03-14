using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePingEntry : CVariable
	{
		private wCHandle<gameObject> _owner;
		private Vector4 _worldPosition;
		private netTime _time;
		private CEnum<gamedataPingType> _pingType;
		private wCHandle<entEntity> _hitObject;

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
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get
			{
				if (_worldPosition == null)
				{
					_worldPosition = (Vector4) CR2WTypeManager.Create("Vector4", "worldPosition", cr2w, this);
				}
				return _worldPosition;
			}
			set
			{
				if (_worldPosition == value)
				{
					return;
				}
				_worldPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("time")] 
		public netTime Time
		{
			get
			{
				if (_time == null)
				{
					_time = (netTime) CR2WTypeManager.Create("netTime", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pingType")] 
		public CEnum<gamedataPingType> PingType
		{
			get
			{
				if (_pingType == null)
				{
					_pingType = (CEnum<gamedataPingType>) CR2WTypeManager.Create("gamedataPingType", "pingType", cr2w, this);
				}
				return _pingType;
			}
			set
			{
				if (_pingType == value)
				{
					return;
				}
				_pingType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hitObject")] 
		public wCHandle<entEntity> HitObject
		{
			get
			{
				if (_hitObject == null)
				{
					_hitObject = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "hitObject", cr2w, this);
				}
				return _hitObject;
			}
			set
			{
				if (_hitObject == value)
				{
					return;
				}
				_hitObject = value;
				PropertySet(this);
			}
		}

		public gamePingEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
