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
			get => GetProperty(ref _startFrame);
			set => SetProperty(ref _startFrame, value);
		}

		[Ordinal(1)] 
		[RED("durationInFrames")] 
		public CUInt32 DurationInFrames
		{
			get => GetProperty(ref _durationInFrames);
			set => SetProperty(ref _durationInFrames, value);
		}

		[Ordinal(2)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		public animAnimEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
