using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnsimActionsScenariosNodeScenarios : CVariable
	{
		private scnNodeId _nodeId;
		private CArray<CHandle<scnsimIActionScenario>> _scenarios;
		private CHandle<scnsimIActionScenario> _fallback;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get
			{
				if (_nodeId == null)
				{
					_nodeId = (scnNodeId) CR2WTypeManager.Create("scnNodeId", "nodeId", cr2w, this);
				}
				return _nodeId;
			}
			set
			{
				if (_nodeId == value)
				{
					return;
				}
				_nodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("scenarios")] 
		public CArray<CHandle<scnsimIActionScenario>> Scenarios
		{
			get
			{
				if (_scenarios == null)
				{
					_scenarios = (CArray<CHandle<scnsimIActionScenario>>) CR2WTypeManager.Create("array:handle:scnsimIActionScenario", "scenarios", cr2w, this);
				}
				return _scenarios;
			}
			set
			{
				if (_scenarios == value)
				{
					return;
				}
				_scenarios = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fallback")] 
		public CHandle<scnsimIActionScenario> Fallback
		{
			get
			{
				if (_fallback == null)
				{
					_fallback = (CHandle<scnsimIActionScenario>) CR2WTypeManager.Create("handle:scnsimIActionScenario", "fallback", cr2w, this);
				}
				return _fallback;
			}
			set
			{
				if (_fallback == value)
				{
					return;
				}
				_fallback = value;
				PropertySet(this);
			}
		}

		public scnsimActionsScenariosNodeScenarios(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
