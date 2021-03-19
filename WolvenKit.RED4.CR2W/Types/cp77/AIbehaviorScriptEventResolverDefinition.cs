using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorScriptEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		private CHandle<AIbehavioreventResolverScript> _script;

		[Ordinal(0)] 
		[RED("script")] 
		public CHandle<AIbehavioreventResolverScript> Script
		{
			get => GetProperty(ref _script);
			set => SetProperty(ref _script, value);
		}

		public AIbehaviorScriptEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
