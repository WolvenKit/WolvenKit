using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexUnlockRecordRequest : gameScriptableSystemRequest
	{
		private TweakDBID _codexRecordID;

		[Ordinal(0)] 
		[RED("codexRecordID")] 
		public TweakDBID CodexRecordID
		{
			get => GetProperty(ref _codexRecordID);
			set => SetProperty(ref _codexRecordID, value);
		}
	}
}
