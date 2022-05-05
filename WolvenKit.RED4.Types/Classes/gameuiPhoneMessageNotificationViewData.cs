using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhoneMessageNotificationViewData : gameuiQuestUpdateNotificationViewData
	{
		[Ordinal(14)] 
		[RED("threadHash")] 
		public CInt32 ThreadHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("contactHash")] 
		public CInt32 ContactHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiPhoneMessageNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
