using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SendScoreRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("score")] 
		public CInt32 Score
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("gameName")] 
		public CString GameName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SendScoreRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
