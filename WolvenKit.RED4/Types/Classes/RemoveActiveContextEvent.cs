using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveActiveContextEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("context")] 
		public CEnum<gamedeviceRequestType> Context
		{
			get => GetPropertyValue<CEnum<gamedeviceRequestType>>();
			set => SetPropertyValue<CEnum<gamedeviceRequestType>>(value);
		}

		public RemoveActiveContextEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
