using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalPhoneMessage : gameJournalEntry
	{
		[Ordinal(1)] 
		[RED("sender")] 
		public CEnum<gameMessageSender> Sender
		{
			get => GetPropertyValue<CEnum<gameMessageSender>>();
			set => SetPropertyValue<CEnum<gameMessageSender>>(value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(3)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("attachment")] 
		public CHandle<gameJournalPath> Attachment
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		public gameJournalPhoneMessage()
		{
			Text = new() { Unk1 = 0, Value = "" };
			Delay = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
