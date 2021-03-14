using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhoneCallMode_ConditionType : questIPhoneConditionType
	{
		private CEnum<questPhoneCallMode> _callMode;

		[Ordinal(1)] 
		[RED("callMode")] 
		public CEnum<questPhoneCallMode> CallMode
		{
			get
			{
				if (_callMode == null)
				{
					_callMode = (CEnum<questPhoneCallMode>) CR2WTypeManager.Create("questPhoneCallMode", "callMode", cr2w, this);
				}
				return _callMode;
			}
			set
			{
				if (_callMode == value)
				{
					return;
				}
				_callMode = value;
				PropertySet(this);
			}
		}

		public questPhoneCallMode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
