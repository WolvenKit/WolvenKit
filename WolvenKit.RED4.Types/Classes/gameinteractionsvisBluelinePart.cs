using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsvisBluelinePart : IScriptable
	{
		private CBool _passed;
		private TweakDBID _captionIconRecordId;

		[Ordinal(0)] 
		[RED("passed")] 
		public CBool Passed
		{
			get => GetProperty(ref _passed);
			set => SetProperty(ref _passed, value);
		}

		[Ordinal(1)] 
		[RED("captionIconRecordId")] 
		public TweakDBID CaptionIconRecordId
		{
			get => GetProperty(ref _captionIconRecordId);
			set => SetProperty(ref _captionIconRecordId, value);
		}
	}
}
