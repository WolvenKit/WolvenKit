using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolSpentPrereqListener : BaseStatPoolPrereqListener
	{
		private wCHandle<StatPoolSpentPrereqState> _state;
		private CFloat _overallSpentValue;

		[Ordinal(0)] 
		[RED("state")] 
		public wCHandle<StatPoolSpentPrereqState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (wCHandle<StatPoolSpentPrereqState>) CR2WTypeManager.Create("whandle:StatPoolSpentPrereqState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("overallSpentValue")] 
		public CFloat OverallSpentValue
		{
			get
			{
				if (_overallSpentValue == null)
				{
					_overallSpentValue = (CFloat) CR2WTypeManager.Create("Float", "overallSpentValue", cr2w, this);
				}
				return _overallSpentValue;
			}
			set
			{
				if (_overallSpentValue == value)
				{
					return;
				}
				_overallSpentValue = value;
				PropertySet(this);
			}
		}

		public StatPoolSpentPrereqListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
