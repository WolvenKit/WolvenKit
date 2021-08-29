using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnlockCodexPartRequest : gameScriptableSystemRequest
	{
		private TweakDBID _codexRecordID;
		private CName _partName;

		[Ordinal(0)] 
		[RED("codexRecordID")] 
		public TweakDBID CodexRecordID
		{
			get => GetProperty(ref _codexRecordID);
			set => SetProperty(ref _codexRecordID, value);
		}

		[Ordinal(1)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}
	}
}
