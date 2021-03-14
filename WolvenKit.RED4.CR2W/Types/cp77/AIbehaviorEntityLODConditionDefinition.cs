using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEntityLODConditionDefinition : AIbehaviorConditionDefinition
	{
		private CArray<CEnum<AIbehaviorEntityLODConditions>> _any;
		private CArray<CEnum<AIbehaviorEntityLODConditions>> _all;
		private CArray<CEnum<AIbehaviorEntityLODConditions>> _none;

		[Ordinal(1)] 
		[RED("any")] 
		public CArray<CEnum<AIbehaviorEntityLODConditions>> Any
		{
			get
			{
				if (_any == null)
				{
					_any = (CArray<CEnum<AIbehaviorEntityLODConditions>>) CR2WTypeManager.Create("array:AIbehaviorEntityLODConditions", "any", cr2w, this);
				}
				return _any;
			}
			set
			{
				if (_any == value)
				{
					return;
				}
				_any = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("all")] 
		public CArray<CEnum<AIbehaviorEntityLODConditions>> All
		{
			get
			{
				if (_all == null)
				{
					_all = (CArray<CEnum<AIbehaviorEntityLODConditions>>) CR2WTypeManager.Create("array:AIbehaviorEntityLODConditions", "all", cr2w, this);
				}
				return _all;
			}
			set
			{
				if (_all == value)
				{
					return;
				}
				_all = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("none")] 
		public CArray<CEnum<AIbehaviorEntityLODConditions>> None
		{
			get
			{
				if (_none == null)
				{
					_none = (CArray<CEnum<AIbehaviorEntityLODConditions>>) CR2WTypeManager.Create("array:AIbehaviorEntityLODConditions", "none", cr2w, this);
				}
				return _none;
			}
			set
			{
				if (_none == value)
				{
					return;
				}
				_none = value;
				PropertySet(this);
			}
		}

		public AIbehaviorEntityLODConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
