using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LcdScreenControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("messageRecordID")] 
		public TweakDBID MessageRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(105)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(106)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(107)] 
		[RED("messageRecordSelector")] 
		public CHandle<ScreenMessageSelector> MessageRecordSelector
		{
			get => GetPropertyValue<CHandle<ScreenMessageSelector>>();
			set => SetPropertyValue<CHandle<ScreenMessageSelector>>(value);
		}

		public LcdScreenControllerPS()
		{
			DeviceName = "LocKey#193";
			TweakDBRecord = 76891147553;
			TweakDBDescriptionRecord = 126712954239;
			DisableQuickHacks = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
