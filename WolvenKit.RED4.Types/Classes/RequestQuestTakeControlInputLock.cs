using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestQuestTakeControlInputLock : gameScriptableSystemRequest
	{
		private CBool _isLocked;
		private CBool _isChainForced;

		[Ordinal(0)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(1)] 
		[RED("isChainForced")] 
		public CBool IsChainForced
		{
			get => GetProperty(ref _isChainForced);
			set => SetProperty(ref _isChainForced, value);
		}
	}
}
