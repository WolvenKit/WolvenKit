using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTimeoutNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _time;

		[Ordinal(1)] 
		[RED("time")] 
		public CHandle<AIArgumentMapping> Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		public AIbehaviorTimeoutNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
