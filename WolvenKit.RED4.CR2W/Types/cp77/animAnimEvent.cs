using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent : ISerializable
	{
		private CUInt32 _startFrame;
		private CUInt32 _durationInFrames;
		private CName _eventName;

		[Ordinal(0)] 
		[RED("startFrame")] 
		public CUInt32 StartFrame
		{
			get
			{
				if (_startFrame == null)
				{
					_startFrame = (CUInt32) CR2WTypeManager.Create("Uint32", "startFrame", cr2w, this);
				}
				return _startFrame;
			}
			set
			{
				if (_startFrame == value)
				{
					return;
				}
				_startFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("durationInFrames")] 
		public CUInt32 DurationInFrames
		{
			get
			{
				if (_durationInFrames == null)
				{
					_durationInFrames = (CUInt32) CR2WTypeManager.Create("Uint32", "durationInFrames", cr2w, this);
				}
				return _durationInFrames;
			}
			set
			{
				if (_durationInFrames == value)
				{
					return;
				}
				_durationInFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("eventName")] 
		public CName EventName
		{
			get
			{
				if (_eventName == null)
				{
					_eventName = (CName) CR2WTypeManager.Create("CName", "eventName", cr2w, this);
				}
				return _eventName;
			}
			set
			{
				if (_eventName == value)
				{
					return;
				}
				_eventName = value;
				PropertySet(this);
			}
		}

		public animAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
