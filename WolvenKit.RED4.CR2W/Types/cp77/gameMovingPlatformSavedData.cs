using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformSavedData : CVariable
	{
		private CHandle<gameIMovingPlatformMovement> _movement;
		private CName _destinationName;
		private CInt32 _destinationData;
		private CFloat _time;
		private CFloat _maxTime;
		private CUInt32 _mountedPlayerEntityID;

		[Ordinal(0)] 
		[RED("movement")] 
		public CHandle<gameIMovingPlatformMovement> Movement
		{
			get
			{
				if (_movement == null)
				{
					_movement = (CHandle<gameIMovingPlatformMovement>) CR2WTypeManager.Create("handle:gameIMovingPlatformMovement", "movement", cr2w, this);
				}
				return _movement;
			}
			set
			{
				if (_movement == value)
				{
					return;
				}
				_movement = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("destinationName")] 
		public CName DestinationName
		{
			get
			{
				if (_destinationName == null)
				{
					_destinationName = (CName) CR2WTypeManager.Create("CName", "destinationName", cr2w, this);
				}
				return _destinationName;
			}
			set
			{
				if (_destinationName == value)
				{
					return;
				}
				_destinationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("destinationData")] 
		public CInt32 DestinationData
		{
			get
			{
				if (_destinationData == null)
				{
					_destinationData = (CInt32) CR2WTypeManager.Create("Int32", "destinationData", cr2w, this);
				}
				return _destinationData;
			}
			set
			{
				if (_destinationData == value)
				{
					return;
				}
				_destinationData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
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

		[Ordinal(4)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get
			{
				if (_maxTime == null)
				{
					_maxTime = (CFloat) CR2WTypeManager.Create("Float", "maxTime", cr2w, this);
				}
				return _maxTime;
			}
			set
			{
				if (_maxTime == value)
				{
					return;
				}
				_maxTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("mountedPlayerEntityID")] 
		public CUInt32 MountedPlayerEntityID
		{
			get
			{
				if (_mountedPlayerEntityID == null)
				{
					_mountedPlayerEntityID = (CUInt32) CR2WTypeManager.Create("Uint32", "mountedPlayerEntityID", cr2w, this);
				}
				return _mountedPlayerEntityID;
			}
			set
			{
				if (_mountedPlayerEntityID == value)
				{
					return;
				}
				_mountedPlayerEntityID = value;
				PropertySet(this);
			}
		}

		public gameMovingPlatformSavedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
