using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestQuestTakeControlInputLock : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isChainForced")] 
		public CBool IsChainForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RequestQuestTakeControlInputLock()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
