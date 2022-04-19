using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SToggleOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("classType")] 
		public CEnum<EOperationClassType> ClassType
		{
			get => GetPropertyValue<CEnum<EOperationClassType>>();
			set => SetPropertyValue<CEnum<EOperationClassType>>(value);
		}

		public SToggleOperationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
