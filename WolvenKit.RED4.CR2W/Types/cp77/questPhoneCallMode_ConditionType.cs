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
			get => GetProperty(ref _callMode);
			set => SetProperty(ref _callMode, value);
		}

		public questPhoneCallMode_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
