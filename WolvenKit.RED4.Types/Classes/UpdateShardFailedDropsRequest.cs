using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateShardFailedDropsRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("resetCounter")] 
		public CBool ResetCounter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("newFailedAttempts")] 
		public CFloat NewFailedAttempts
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public UpdateShardFailedDropsRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
