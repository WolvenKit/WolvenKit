using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionReplicatedState : CVariable
	{
		private CUInt32 _replicationId;
		private CUInt16 _type;
		private netTime _startTimeStamp;
		private netTime _stopTimeStamp;
		private CUInt8 _updateBucket;

		[Ordinal(0)] 
		[RED("replicationId")] 
		public CUInt32 ReplicationId
		{
			get
			{
				if (_replicationId == null)
				{
					_replicationId = (CUInt32) CR2WTypeManager.Create("Uint32", "replicationId", cr2w, this);
				}
				return _replicationId;
			}
			set
			{
				if (_replicationId == value)
				{
					return;
				}
				_replicationId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CUInt16 Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CUInt16) CR2WTypeManager.Create("Uint16", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startTimeStamp")] 
		public netTime StartTimeStamp
		{
			get
			{
				if (_startTimeStamp == null)
				{
					_startTimeStamp = (netTime) CR2WTypeManager.Create("netTime", "startTimeStamp", cr2w, this);
				}
				return _startTimeStamp;
			}
			set
			{
				if (_startTimeStamp == value)
				{
					return;
				}
				_startTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stopTimeStamp")] 
		public netTime StopTimeStamp
		{
			get
			{
				if (_stopTimeStamp == null)
				{
					_stopTimeStamp = (netTime) CR2WTypeManager.Create("netTime", "stopTimeStamp", cr2w, this);
				}
				return _stopTimeStamp;
			}
			set
			{
				if (_stopTimeStamp == value)
				{
					return;
				}
				_stopTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("updateBucket")] 
		public CUInt8 UpdateBucket
		{
			get
			{
				if (_updateBucket == null)
				{
					_updateBucket = (CUInt8) CR2WTypeManager.Create("Uint8", "updateBucket", cr2w, this);
				}
				return _updateBucket;
			}
			set
			{
				if (_updateBucket == value)
				{
					return;
				}
				_updateBucket = value;
				PropertySet(this);
			}
		}

		public gameActionReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
