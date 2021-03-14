using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOverrideInterruptionScenario_InterruptionOperation : scnIInterruptionOperation
	{
		private scnInterruptionScenarioId _scenarioId;
		private CArray<CHandle<scnIInterruptionScenarioOperation>> _scenarioOperations;

		[Ordinal(0)] 
		[RED("scenarioId")] 
		public scnInterruptionScenarioId ScenarioId
		{
			get
			{
				if (_scenarioId == null)
				{
					_scenarioId = (scnInterruptionScenarioId) CR2WTypeManager.Create("scnInterruptionScenarioId", "scenarioId", cr2w, this);
				}
				return _scenarioId;
			}
			set
			{
				if (_scenarioId == value)
				{
					return;
				}
				_scenarioId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("scenarioOperations")] 
		public CArray<CHandle<scnIInterruptionScenarioOperation>> ScenarioOperations
		{
			get
			{
				if (_scenarioOperations == null)
				{
					_scenarioOperations = (CArray<CHandle<scnIInterruptionScenarioOperation>>) CR2WTypeManager.Create("array:handle:scnIInterruptionScenarioOperation", "scenarioOperations", cr2w, this);
				}
				return _scenarioOperations;
			}
			set
			{
				if (_scenarioOperations == value)
				{
					return;
				}
				_scenarioOperations = value;
				PropertySet(this);
			}
		}

		public scnOverrideInterruptionScenario_InterruptionOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
