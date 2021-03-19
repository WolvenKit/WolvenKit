using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCreationPrereq : gameIScriptablePrereq
	{
		private CBool _fireAndForget;
		private CEnum<gamedataStatType> _statType;
		private CFloat _valueToCheck;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("fireAndForget")] 
		public CBool FireAndForget
		{
			get => GetProperty(ref _fireAndForget);
			set => SetProperty(ref _fireAndForget, value);
		}

		[Ordinal(1)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(2)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetProperty(ref _valueToCheck);
			set => SetProperty(ref _valueToCheck, value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		public ItemCreationPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
