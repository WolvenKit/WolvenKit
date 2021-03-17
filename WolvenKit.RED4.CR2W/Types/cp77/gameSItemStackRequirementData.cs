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
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(1)] 
		[RED("requiredValue")] 
		public CFloat RequiredValue
		{
			get => GetProperty(ref _requiredValue);
			set => SetProperty(ref _requiredValue, value);
		}

		public gameSItemStackRequirementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
