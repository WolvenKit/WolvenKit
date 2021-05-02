using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITreeNodeRepeatDefinition : AICTreeNodeDecoratorDefinition
	{
		private LibTreeDefInt32 _limit;

		[Ordinal(1)] 
		[RED("limit")] 
		public LibTreeDefInt32 Limit
		{
			get => GetProperty(ref _limit);
			set => SetProperty(ref _limit, value);
		}

		public AITreeNodeRepeatDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
