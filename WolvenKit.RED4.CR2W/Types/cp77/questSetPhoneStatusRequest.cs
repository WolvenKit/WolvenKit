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
			get
			{
				if (_status == null)
				{
					_status = (CName) CR2WTypeManager.Create("CName", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		public questSetPhoneStatusRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
