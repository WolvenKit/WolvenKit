using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeTableCallbackRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("callBackID")] public CUInt32 CallBackID { get; set; }

		public TimeTableCallbackRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
