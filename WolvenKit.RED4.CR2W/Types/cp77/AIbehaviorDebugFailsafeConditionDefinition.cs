using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDebugFailsafeConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _logMessage;

		[Ordinal(1)] 
		[RED("logMessage")] 
		public CHandle<AIArgumentMapping> LogMessage
		{
			get => GetProperty(ref _logMessage);
			set => SetProperty(ref _logMessage, value);
		}

		public AIbehaviorDebugFailsafeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
