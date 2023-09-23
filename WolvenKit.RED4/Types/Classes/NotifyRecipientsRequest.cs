using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NotifyRecipientsRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("recipients")] 
		public CArray<RecipientData> Recipients
		{
			get => GetPropertyValue<CArray<RecipientData>>();
			set => SetPropertyValue<CArray<RecipientData>>(value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public GameTime Time
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		public NotifyRecipientsRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
