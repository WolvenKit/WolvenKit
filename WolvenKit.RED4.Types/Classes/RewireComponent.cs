using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RewireComponent : gameScriptableComponent
	{
		private redResourceReferenceScriptToken _miniGameVideoPath;
		private CName _miniGameAudioEvent;
		private CFloat _miniGameVideoLenght;
		private CHandle<RewireEvent> _rewireEvent;
		private CFloat _rewireCurrentLenght;
		private CBool _isActive;

		[Ordinal(5)] 
		[RED("miniGameVideoPath")] 
		public redResourceReferenceScriptToken MiniGameVideoPath
		{
			get => GetProperty(ref _miniGameVideoPath);
			set => SetProperty(ref _miniGameVideoPath, value);
		}

		[Ordinal(6)] 
		[RED("miniGameAudioEvent")] 
		public CName MiniGameAudioEvent
		{
			get => GetProperty(ref _miniGameAudioEvent);
			set => SetProperty(ref _miniGameAudioEvent, value);
		}

		[Ordinal(7)] 
		[RED("miniGameVideoLenght")] 
		public CFloat MiniGameVideoLenght
		{
			get => GetProperty(ref _miniGameVideoLenght);
			set => SetProperty(ref _miniGameVideoLenght, value);
		}

		[Ordinal(8)] 
		[RED("rewireEvent")] 
		public CHandle<RewireEvent> RewireEvent
		{
			get => GetProperty(ref _rewireEvent);
			set => SetProperty(ref _rewireEvent, value);
		}

		[Ordinal(9)] 
		[RED("rewireCurrentLenght")] 
		public CFloat RewireCurrentLenght
		{
			get => GetProperty(ref _rewireCurrentLenght);
			set => SetProperty(ref _rewireCurrentLenght, value);
		}

		[Ordinal(10)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		public RewireComponent()
		{
			_miniGameVideoLenght = 5.000000F;
		}
	}
}
