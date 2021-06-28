using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetCurrentPatrolSpotActionPath : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _outPathArgument;

		[Ordinal(0)] 
		[RED("outPathArgument")] 
		public CHandle<AIArgumentMapping> OutPathArgument
		{
			get => GetProperty(ref _outPathArgument);
			set => SetProperty(ref _outPathArgument, value);
		}

		public GetCurrentPatrolSpotActionPath(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
