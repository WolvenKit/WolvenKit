using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectSingleFilter_BlackboardBoolCondition : gameEffectObjectSingleFilter
	{
		private gameEffectInputParameter_Bool _parameter;
		private CHandle<gameEffectObjectSingleFilter> _filter;

		[Ordinal(0)] 
		[RED("parameter")] 
		public gameEffectInputParameter_Bool Parameter
		{
			get
			{
				if (_parameter == null)
				{
					_parameter = (gameEffectInputParameter_Bool) CR2WTypeManager.Create("gameEffectInputParameter_Bool", "parameter", cr2w, this);
				}
				return _parameter;
			}
			set
			{
				if (_parameter == value)
				{
					return;
				}
				_parameter = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("filter")] 
		public CHandle<gameEffectObjectSingleFilter> Filter
		{
			get
			{
				if (_filter == null)
				{
					_filter = (CHandle<gameEffectObjectSingleFilter>) CR2WTypeManager.Create("handle:gameEffectObjectSingleFilter", "filter", cr2w, this);
				}
				return _filter;
			}
			set
			{
				if (_filter == value)
				{
					return;
				}
				_filter = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectSingleFilter_BlackboardBoolCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
