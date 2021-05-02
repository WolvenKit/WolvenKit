using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDelayedFunctionsScheduler : ISerializable
	{
		private CBool _initialized;
		private EngineTime _currentTime;
		private CUInt32 _nextCallId;

		[Ordinal(0)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		[Ordinal(1)] 
		[RED("currentTime")] 
		public EngineTime CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		[Ordinal(2)] 
		[RED("nextCallId")] 
		public CUInt32 NextCallId
		{
			get => GetProperty(ref _nextCallId);
			set => SetProperty(ref _nextCallId, value);
		}

		public gameDelayedFunctionsScheduler(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
