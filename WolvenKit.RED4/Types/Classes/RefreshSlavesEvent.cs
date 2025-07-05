using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RefreshSlavesEvent : ProcessDevicesEvent
	{
		[Ordinal(1)] 
		[RED("onInitialize")] 
		public CBool OnInitialize
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RefreshSlavesEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
