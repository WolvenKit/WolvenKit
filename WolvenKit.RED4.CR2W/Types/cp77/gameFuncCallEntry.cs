using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFuncCallEntry : ISerializable
	{
		private EngineTime _callTime;
		private CUInt32 _callId;

		[Ordinal(0)] 
		[RED("callTime")] 
		public EngineTime CallTime
		{
			get => GetProperty(ref _callTime);
			set => SetProperty(ref _callTime, value);
		}

		[Ordinal(1)] 
		[RED("callId")] 
		public CUInt32 CallId
		{
			get => GetProperty(ref _callId);
			set => SetProperty(ref _callId, value);
		}

		public gameFuncCallEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
