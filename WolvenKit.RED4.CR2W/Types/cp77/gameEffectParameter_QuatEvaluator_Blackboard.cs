using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_QuatEvaluator_Blackboard : gameIEffectParameter_QuatEvaluator
	{
		private gameBlackboardPropertyBindingDefinition _blackboardProperty;

		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get
			{
				if (_blackboardProperty == null)
				{
					_blackboardProperty = (gameBlackboardPropertyBindingDefinition) CR2WTypeManager.Create("gameBlackboardPropertyBindingDefinition", "blackboardProperty", cr2w, this);
				}
				return _blackboardProperty;
			}
			set
			{
				if (_blackboardProperty == value)
				{
					return;
				}
				_blackboardProperty = value;
				PropertySet(this);
			}
		}

		public gameEffectParameter_QuatEvaluator_Blackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
