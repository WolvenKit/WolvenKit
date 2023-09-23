using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LcdScreenControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("messageRecordID")] 
		public TweakDBID MessageRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(108)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(110)] 
		[RED("messageRecordSelector")] 
		public CHandle<ScreenMessageSelector> MessageRecordSelector
		{
			get => GetPropertyValue<CHandle<ScreenMessageSelector>>();
			set => SetPropertyValue<CHandle<ScreenMessageSelector>>(value);
		}

		public LcdScreenControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
