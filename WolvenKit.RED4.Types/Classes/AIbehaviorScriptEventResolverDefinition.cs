using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorScriptEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		private CHandle<AIbehavioreventResolverScript> _script;

		[Ordinal(0)] 
		[RED("script")] 
		public CHandle<AIbehavioreventResolverScript> Script
		{
			get => GetProperty(ref _script);
			set => SetProperty(ref _script, value);
		}
	}
}
