using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhoneCallPhase_ConditionType : questIPhoneConditionType
	{
		private CEnum<questPhoneCallPhase> _callPhase;

		[Ordinal(1)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get
			{
				if (_callPhase == null)
				{
					_callPhase = (CEnum<questPhoneCallPhase>) CR2WTypeManager.Create("questPhoneCallPhase", "callPhase", cr2w, this);
				}
				return _callPhase;
			}
			set
			{
				if (_callPhase == value)
				{
					return;
				}
				_callPhase = value;
				PropertySet(this);
			}
		}

		public questPhoneCallPhase_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
