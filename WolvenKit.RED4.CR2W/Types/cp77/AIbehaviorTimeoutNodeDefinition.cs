using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTimeoutNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _time;

		[Ordinal(1)] 
		[RED("time")] 
		public CHandle<AIArgumentMapping> Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		public AIbehaviorTimeoutNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
