using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SWorkspotData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("freeCamera")] 
		public CBool FreeCamera
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("operationType")] 
		public CEnum<EWorkspotOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<EWorkspotOperationType>>();
			set => SetPropertyValue<CEnum<EWorkspotOperationType>>(value);
		}

		public SWorkspotData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
