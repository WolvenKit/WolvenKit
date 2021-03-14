using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharParamTimeout : AITimeoutCondition
	{
		private CString _timeoutParamName;

		[Ordinal(1)] 
		[RED("timeoutParamName")] 
		public CString TimeoutParamName
		{
			get
			{
				if (_timeoutParamName == null)
				{
					_timeoutParamName = (CString) CR2WTypeManager.Create("String", "timeoutParamName", cr2w, this);
				}
				return _timeoutParamName;
			}
			set
			{
				if (_timeoutParamName == value)
				{
					return;
				}
				_timeoutParamName = value;
				PropertySet(this);
			}
		}

		public CharParamTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
