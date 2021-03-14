using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LightSwitchRequest : redEvent
	{
		private CInt32 _requestNumber;

		[Ordinal(0)] 
		[RED("requestNumber")] 
		public CInt32 RequestNumber
		{
			get
			{
				if (_requestNumber == null)
				{
					_requestNumber = (CInt32) CR2WTypeManager.Create("Int32", "requestNumber", cr2w, this);
				}
				return _requestNumber;
			}
			set
			{
				if (_requestNumber == value)
				{
					return;
				}
				_requestNumber = value;
				PropertySet(this);
			}
		}

		public LightSwitchRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
