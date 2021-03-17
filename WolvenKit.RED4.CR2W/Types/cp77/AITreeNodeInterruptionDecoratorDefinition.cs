using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITreeNodeInterruptionDecoratorDefinition : AICTreeNodeDecoratorDefinition
	{
		private CArray<CHandle<AIInterruptionHandlerDefinition>> _interruptions;

		[Ordinal(1)] 
		[RED("interruptions")] 
		public CArray<CHandle<AIInterruptionHandlerDefinition>> Interruptions
		{
			get => GetProperty(ref _interruptions);
			set => SetProperty(ref _interruptions, value);
		}

		public AITreeNodeInterruptionDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
