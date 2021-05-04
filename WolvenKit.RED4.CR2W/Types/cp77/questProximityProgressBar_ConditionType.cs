using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questProximityProgressBar_ConditionType : questIUIConditionType
	{
		private CEnum<questProximityProgressBarAction> _action;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questProximityProgressBarAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		public questProximityProgressBar_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
