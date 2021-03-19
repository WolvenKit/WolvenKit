using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetPhoneStatusRequest : gameScriptableSystemRequest
	{
		private CName _status;

		[Ordinal(0)] 
		[RED("status")] 
		public CName Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		public questSetPhoneStatusRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
