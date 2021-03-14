using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PingSquadEffector : gameEffector
	{
		private CArray<entEntityID> _squadMembers;
		private wCHandle<gameObject> _owner;
		private CHandle<gameAttitudeAgent> _oldSquadAttitude;
		private CFloat _quickhackLevel;
		private CHandle<FocusForcedHighlightData> _data;

		[Ordinal(0)] 
		[RED("squadMembers")] 
		public CArray<entEntityID> SquadMembers
		{
			get
			{
				if (_squadMembers == null)
				{
					_squadMembers = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "squadMembers", cr2w, this);
				}
				return _squadMembers;
			}
			set
			{
				if (_squadMembers == value)
				{
					return;
				}
				_squadMembers = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("oldSquadAttitude")] 
		public CHandle<gameAttitudeAgent> OldSquadAttitude
		{
			get
			{
				if (_oldSquadAttitude == null)
				{
					_oldSquadAttitude = (CHandle<gameAttitudeAgent>) CR2WTypeManager.Create("handle:gameAttitudeAgent", "oldSquadAttitude", cr2w, this);
				}
				return _oldSquadAttitude;
			}
			set
			{
				if (_oldSquadAttitude == value)
				{
					return;
				}
				_oldSquadAttitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("quickhackLevel")] 
		public CFloat QuickhackLevel
		{
			get
			{
				if (_quickhackLevel == null)
				{
					_quickhackLevel = (CFloat) CR2WTypeManager.Create("Float", "quickhackLevel", cr2w, this);
				}
				return _quickhackLevel;
			}
			set
			{
				if (_quickhackLevel == value)
				{
					return;
				}
				_quickhackLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<FocusForcedHighlightData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<FocusForcedHighlightData>) CR2WTypeManager.Create("handle:FocusForcedHighlightData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public PingSquadEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
