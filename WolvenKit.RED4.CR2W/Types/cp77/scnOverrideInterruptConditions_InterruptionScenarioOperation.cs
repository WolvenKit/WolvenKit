using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOverrideInterruptConditions_InterruptionScenarioOperation : scnIInterruptionScenarioOperation
	{
		private CArray<CHandle<scnIInterruptCondition>> _interruptConditions;

		[Ordinal(0)] 
		[RED("interruptConditions")] 
		public CArray<CHandle<scnIInterruptCondition>> InterruptConditions
		{
			get => GetProperty(ref _interruptConditions);
			set => SetProperty(ref _interruptConditions, value);
		}

		public scnOverrideInterruptConditions_InterruptionScenarioOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
