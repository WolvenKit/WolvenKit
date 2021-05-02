using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AssignRestrictMovementAreaTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _restrictMovementAreaRef;

		[Ordinal(0)] 
		[RED("restrictMovementAreaRef")] 
		public CHandle<AIArgumentMapping> RestrictMovementAreaRef
		{
			get => GetProperty(ref _restrictMovementAreaRef);
			set => SetProperty(ref _restrictMovementAreaRef, value);
		}

		public AssignRestrictMovementAreaTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
