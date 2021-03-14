using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneEvent : ISerializable
	{
		private scnSceneEventId _id;
		private CEnum<scnEventType> _type;
		private CUInt32 _startTime;
		private CUInt32 _duration;
		private CUInt8 _executionTagFlags;
		private CHandle<scnIScalingData> _scalingData;

		[Ordinal(0)] 
		[RED("id")] 
		public scnSceneEventId Id
		{
			get
			{
				if (_id == null)
				{
					_id = (scnSceneEventId) CR2WTypeManager.Create("scnSceneEventId", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<scnEventType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<scnEventType>) CR2WTypeManager.Create("scnEventType", "type", cr2w, this);
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
		[RED("startTime")] 
		public CUInt32 StartTime
		{
			get
			{
				if (_startTime == null)
				{
					_startTime = (CUInt32) CR2WTypeManager.Create("Uint32", "startTime", cr2w, this);
				}
				return _startTime;
			}
			set
			{
				if (_startTime == value)
				{
					return;
				}
				_startTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CUInt32 Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CUInt32) CR2WTypeManager.Create("Uint32", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("executionTagFlags")] 
		public CUInt8 ExecutionTagFlags
		{
			get
			{
				if (_executionTagFlags == null)
				{
					_executionTagFlags = (CUInt8) CR2WTypeManager.Create("Uint8", "executionTagFlags", cr2w, this);
				}
				return _executionTagFlags;
			}
			set
			{
				if (_executionTagFlags == value)
				{
					return;
				}
				_executionTagFlags = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scalingData")] 
		public CHandle<scnIScalingData> ScalingData
		{
			get
			{
				if (_scalingData == null)
				{
					_scalingData = (CHandle<scnIScalingData>) CR2WTypeManager.Create("handle:scnIScalingData", "scalingData", cr2w, this);
				}
				return _scalingData;
			}
			set
			{
				if (_scalingData == value)
				{
					return;
				}
				_scalingData = value;
				PropertySet(this);
			}
		}

		public scnSceneEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
