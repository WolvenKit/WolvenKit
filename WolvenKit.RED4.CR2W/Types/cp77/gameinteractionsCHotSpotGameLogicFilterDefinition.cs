using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotGameLogicFilterDefinition : ISerializable
	{
		private CHandle<gameIPrereq> _hotSpotPrereq;
		private CHandle<gameIPrereq> _activatorPrereq;
		private CHandle<gameinteractionsInteractionScriptedCondition> _scriptedConditionClass;

		[Ordinal(0)] 
		[RED("hotSpotPrereq")] 
		public CHandle<gameIPrereq> HotSpotPrereq
		{
			get
			{
				if (_hotSpotPrereq == null)
				{
					_hotSpotPrereq = (CHandle<gameIPrereq>) CR2WTypeManager.Create("handle:gameIPrereq", "hotSpotPrereq", cr2w, this);
				}
				return _hotSpotPrereq;
			}
			set
			{
				if (_hotSpotPrereq == value)
				{
					return;
				}
				_hotSpotPrereq = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activatorPrereq")] 
		public CHandle<gameIPrereq> ActivatorPrereq
		{
			get
			{
				if (_activatorPrereq == null)
				{
					_activatorPrereq = (CHandle<gameIPrereq>) CR2WTypeManager.Create("handle:gameIPrereq", "activatorPrereq", cr2w, this);
				}
				return _activatorPrereq;
			}
			set
			{
				if (_activatorPrereq == value)
				{
					return;
				}
				_activatorPrereq = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scriptedConditionClass")] 
		public CHandle<gameinteractionsInteractionScriptedCondition> ScriptedConditionClass
		{
			get
			{
				if (_scriptedConditionClass == null)
				{
					_scriptedConditionClass = (CHandle<gameinteractionsInteractionScriptedCondition>) CR2WTypeManager.Create("handle:gameinteractionsInteractionScriptedCondition", "scriptedConditionClass", cr2w, this);
				}
				return _scriptedConditionClass;
			}
			set
			{
				if (_scriptedConditionClass == value)
				{
					return;
				}
				_scriptedConditionClass = value;
				PropertySet(this);
			}
		}

		public gameinteractionsCHotSpotGameLogicFilterDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
