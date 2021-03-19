using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetRandomThreat : AIRandomTasks
	{
		private CHandle<AIArgumentMapping> _outThreatArgument;

		[Ordinal(0)] 
		[RED("outThreatArgument")] 
		public CHandle<AIArgumentMapping> OutThreatArgument
		{
			get => GetProperty(ref _outThreatArgument);
			set => SetProperty(ref _outThreatArgument, value);
		}

		public GetRandomThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
