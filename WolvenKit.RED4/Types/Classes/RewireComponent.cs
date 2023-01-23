using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RewireComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("miniGameVideoPath")] 
		public redResourceReferenceScriptToken MiniGameVideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(6)] 
		[RED("miniGameAudioEvent")] 
		public CName MiniGameAudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("miniGameVideoLenght")] 
		public CFloat MiniGameVideoLenght
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("rewireEvent")] 
		public CHandle<RewireEvent> RewireEvent
		{
			get => GetPropertyValue<CHandle<RewireEvent>>();
			set => SetPropertyValue<CHandle<RewireEvent>>(value);
		}

		[Ordinal(9)] 
		[RED("rewireCurrentLenght")] 
		public CFloat RewireCurrentLenght
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RewireComponent()
		{
			MiniGameVideoPath = new();
			MiniGameVideoLenght = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
