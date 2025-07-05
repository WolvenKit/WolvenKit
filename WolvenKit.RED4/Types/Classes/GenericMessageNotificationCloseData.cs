using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericMessageNotificationCloseData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("identifier")] 
		public CInt32 Identifier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("result")] 
		public CEnum<GenericMessageNotificationResult> Result
		{
			get => GetPropertyValue<CEnum<GenericMessageNotificationResult>>();
			set => SetPropertyValue<CEnum<GenericMessageNotificationResult>>(value);
		}

		public GenericMessageNotificationCloseData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
