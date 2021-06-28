using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeTableCallbackRequest : gameScriptableSystemRequest
	{
		private CUInt32 _callBackID;

		[Ordinal(0)] 
		[RED("callBackID")] 
		public CUInt32 CallBackID
		{
			get => GetProperty(ref _callBackID);
			set => SetProperty(ref _callBackID, value);
		}

		public TimeTableCallbackRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
