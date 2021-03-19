using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResponseEvent : redEvent
	{
		private CHandle<IScriptable> _responseData;

		[Ordinal(0)] 
		[RED("responseData")] 
		public CHandle<IScriptable> ResponseData
		{
			get => GetProperty(ref _responseData);
			set => SetProperty(ref _responseData, value);
		}

		public ResponseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
