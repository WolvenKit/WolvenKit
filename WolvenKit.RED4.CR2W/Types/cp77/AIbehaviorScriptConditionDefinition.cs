using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorScriptConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIbehaviorconditionScript> _script;
		private CBool _disableLazyInitialization;

		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<AIbehaviorconditionScript> Script
		{
			get => GetProperty(ref _script);
			set => SetProperty(ref _script, value);
		}

		[Ordinal(2)] 
		[RED("disableLazyInitialization")] 
		public CBool DisableLazyInitialization
		{
			get => GetProperty(ref _disableLazyInitialization);
			set => SetProperty(ref _disableLazyInitialization, value);
		}

		public AIbehaviorScriptConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
