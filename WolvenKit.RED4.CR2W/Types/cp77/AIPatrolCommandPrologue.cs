using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIPatrolCommandPrologue : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outPatrolPath;

		[Ordinal(1)] 
		[RED("outPatrolPath")] 
		public CHandle<AIArgumentMapping> OutPatrolPath
		{
			get => GetProperty(ref _outPatrolPath);
			set => SetProperty(ref _outPatrolPath, value);
		}

		public AIPatrolCommandPrologue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
