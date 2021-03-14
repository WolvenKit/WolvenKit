using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSItemStackRequirementData : CVariable
	{
		private CEnum<gamedataStatType> _statType;
		private CFloat _requiredValue;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get
			{
				if (_statType == null)
				{
					_statType = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "statType", cr2w, this);
				}
				return _statType;
			}
			set
			{
				if (_statType == value)
				{
					return;
				}
				_statType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requiredValue")] 
		public CFloat RequiredValue
		{
			get
			{
				if (_requiredValue == null)
				{
					_requiredValue = (CFloat) CR2WTypeManager.Create("Float", "requiredValue", cr2w, this);
				}
				return _requiredValue;
			}
			set
			{
				if (_requiredValue == value)
				{
					return;
				}
				_requiredValue = value;
				PropertySet(this);
			}
		}

		public gameSItemStackRequirementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
