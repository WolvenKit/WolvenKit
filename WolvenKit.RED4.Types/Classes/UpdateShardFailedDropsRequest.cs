using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateShardFailedDropsRequest : gameScriptableSystemRequest
	{
		private CBool _resetCounter;
		private CFloat _newFailedAttempts;

		[Ordinal(0)] 
		[RED("resetCounter")] 
		public CBool ResetCounter
		{
			get => GetProperty(ref _resetCounter);
			set => SetProperty(ref _resetCounter, value);
		}

		[Ordinal(1)] 
		[RED("newFailedAttempts")] 
		public CFloat NewFailedAttempts
		{
			get => GetProperty(ref _newFailedAttempts);
			set => SetProperty(ref _newFailedAttempts, value);
		}
	}
}
