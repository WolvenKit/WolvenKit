using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleOperationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<EOperationClassType> Type
		{
			get => GetPropertyValue<CEnum<EOperationClassType>>();
			set => SetPropertyValue<CEnum<EOperationClassType>>(value);
		}

		public ToggleOperationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
