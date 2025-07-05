using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexAddRecordRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("codexRecordID")] 
		public TweakDBID CodexRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public CodexAddRecordRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
