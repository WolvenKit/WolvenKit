using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PoliceSirenTimerRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("red")] 
		public CBool Red
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("fast")] 
		public CBool Fast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("abort")] 
		public CBool Abort
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PoliceSirenTimerRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
