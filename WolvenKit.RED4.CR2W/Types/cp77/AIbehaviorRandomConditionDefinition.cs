using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorRandomConditionDefinition : AIbehaviorConditionDefinition
	{
		private CFloat _chance;

		[Ordinal(1)] 
		[RED("chance")] 
		public CFloat Chance
		{
			get
			{
				if (_chance == null)
				{
					_chance = (CFloat) CR2WTypeManager.Create("Float", "chance", cr2w, this);
				}
				return _chance;
			}
			set
			{
				if (_chance == value)
				{
					return;
				}
				_chance = value;
				PropertySet(this);
			}
		}

		public AIbehaviorRandomConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
