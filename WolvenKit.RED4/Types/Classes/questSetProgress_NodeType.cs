using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetProgress_NodeType : questIAchievementManagerNodeType
	{
		[Ordinal(0)] 
		[RED("achievement")] 
		public TweakDBID Achievement
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CString FactName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("maxValue")] 
		public CUInt32 MaxValue
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("currentValue")] 
		public CUInt32 CurrentValue
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public questSetProgress_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
