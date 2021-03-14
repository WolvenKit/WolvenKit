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
			get
			{
				if (_callBackID == null)
				{
					_callBackID = (CUInt32) CR2WTypeManager.Create("Uint32", "callBackID", cr2w, this);
				}
				return _callBackID;
			}
			set
			{
				if (_callBackID == value)
				{
					return;
				}
				_callBackID = value;
				PropertySet(this);
			}
		}

		public TimeTableCallbackRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
