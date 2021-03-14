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
			get
			{
				if (_responseData == null)
				{
					_responseData = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "responseData", cr2w, this);
				}
				return _responseData;
			}
			set
			{
				if (_responseData == value)
				{
					return;
				}
				_responseData = value;
				PropertySet(this);
			}
		}

		public ResponseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
