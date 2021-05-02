using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckBoolisValid : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _actionTweakIDMapping;

		[Ordinal(0)] 
		[RED("actionTweakIDMapping")] 
		public CHandle<AIArgumentMapping> ActionTweakIDMapping
		{
			get => GetProperty(ref _actionTweakIDMapping);
			set => SetProperty(ref _actionTweakIDMapping, value);
		}

		public CheckBoolisValid(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
