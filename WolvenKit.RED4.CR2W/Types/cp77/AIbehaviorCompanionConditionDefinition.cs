using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCompanionConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _spline;
		private CHandle<AIArgumentMapping> _companion;

		[Ordinal(1)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get
			{
				if (_spline == null)
				{
					_spline = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "spline", cr2w, this);
				}
				return _spline;
			}
			set
			{
				if (_spline == value)
				{
					return;
				}
				_spline = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("companion")] 
		public CHandle<AIArgumentMapping> Companion
		{
			get
			{
				if (_companion == null)
				{
					_companion = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "companion", cr2w, this);
				}
				return _companion;
			}
			set
			{
				if (_companion == value)
				{
					return;
				}
				_companion = value;
				PropertySet(this);
			}
		}

		public AIbehaviorCompanionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
