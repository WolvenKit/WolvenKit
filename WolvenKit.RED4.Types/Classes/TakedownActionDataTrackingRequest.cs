using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownActionDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<ETakedownActionType> EventType
		{
			get => GetPropertyValue<CEnum<ETakedownActionType>>();
			set => SetPropertyValue<CEnum<ETakedownActionType>>(value);
		}
	}
}
