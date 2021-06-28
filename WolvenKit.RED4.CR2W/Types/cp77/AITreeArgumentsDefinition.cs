using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITreeArgumentsDefinition : CVariable
	{
		private CArray<CHandle<AIArgumentDefinition>> _args;

		[Ordinal(0)] 
		[RED("args")] 
		public CArray<CHandle<AIArgumentDefinition>> Args
		{
			get => GetProperty(ref _args);
			set => SetProperty(ref _args, value);
		}

		public AITreeArgumentsDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
