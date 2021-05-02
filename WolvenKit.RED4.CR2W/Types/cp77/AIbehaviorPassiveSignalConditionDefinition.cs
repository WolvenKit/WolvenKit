using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPassiveSignalConditionDefinition : AIbehaviorPassiveConditionDefinition
	{
		private CName _tag;
		private CBool _deactivateSignal;

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(2)] 
		[RED("deactivateSignal")] 
		public CBool DeactivateSignal
		{
			get => GetProperty(ref _deactivateSignal);
			set => SetProperty(ref _deactivateSignal, value);
		}

		public AIbehaviorPassiveSignalConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
