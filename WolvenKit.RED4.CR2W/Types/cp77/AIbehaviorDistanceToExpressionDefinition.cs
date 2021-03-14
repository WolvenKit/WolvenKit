using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDistanceToExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CHandle<AIbehaviorExpressionSocket> _target;
		private CFloat _tolerance;
		private CFloat _updatePeriod;

		[Ordinal(0)] 
		[RED("target")] 
		public CHandle<AIbehaviorExpressionSocket> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CHandle<AIbehaviorExpressionSocket>) CR2WTypeManager.Create("handle:AIbehaviorExpressionSocket", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tolerance")] 
		public CFloat Tolerance
		{
			get
			{
				if (_tolerance == null)
				{
					_tolerance = (CFloat) CR2WTypeManager.Create("Float", "tolerance", cr2w, this);
				}
				return _tolerance;
			}
			set
			{
				if (_tolerance == value)
				{
					return;
				}
				_tolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("updatePeriod")] 
		public CFloat UpdatePeriod
		{
			get
			{
				if (_updatePeriod == null)
				{
					_updatePeriod = (CFloat) CR2WTypeManager.Create("Float", "updatePeriod", cr2w, this);
				}
				return _updatePeriod;
			}
			set
			{
				if (_updatePeriod == value)
				{
					return;
				}
				_updatePeriod = value;
				PropertySet(this);
			}
		}

		public AIbehaviorDistanceToExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
