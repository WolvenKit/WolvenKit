using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownActionDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<ETakedownActionType> _eventType;

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<ETakedownActionType> EventType
		{
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}
	}
}
