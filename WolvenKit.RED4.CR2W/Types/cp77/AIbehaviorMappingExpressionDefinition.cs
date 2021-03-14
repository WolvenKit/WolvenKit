using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMappingExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CHandle<AIArgumentMapping> _mapping;
		private CBool _update;
		private CFloat _updatePeriod;
		private CArray<CName> _behaviorCallbackNames;

		[Ordinal(0)] 
		[RED("mapping")] 
		public CHandle<AIArgumentMapping> Mapping
		{
			get
			{
				if (_mapping == null)
				{
					_mapping = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mapping", cr2w, this);
				}
				return _mapping;
			}
			set
			{
				if (_mapping == value)
				{
					return;
				}
				_mapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("update")] 
		public CBool Update
		{
			get
			{
				if (_update == null)
				{
					_update = (CBool) CR2WTypeManager.Create("Bool", "update", cr2w, this);
				}
				return _update;
			}
			set
			{
				if (_update == value)
				{
					return;
				}
				_update = value;
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

		[Ordinal(3)] 
		[RED("behaviorCallbackNames")] 
		public CArray<CName> BehaviorCallbackNames
		{
			get
			{
				if (_behaviorCallbackNames == null)
				{
					_behaviorCallbackNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "behaviorCallbackNames", cr2w, this);
				}
				return _behaviorCallbackNames;
			}
			set
			{
				if (_behaviorCallbackNames == value)
				{
					return;
				}
				_behaviorCallbackNames = value;
				PropertySet(this);
			}
		}

		public AIbehaviorMappingExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
