using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LCDScreenSelector : inkTweakDBIDSelector
	{
		private TweakDBID _customMessageID;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;

		[Ordinal(1)] 
		[RED("customMessageID")] 
		public TweakDBID CustomMessageID
		{
			get => GetProperty(ref _customMessageID);
			set => SetProperty(ref _customMessageID, value);
		}

		[Ordinal(2)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetProperty(ref _replaceTextWithCustomNumber);
			set => SetProperty(ref _replaceTextWithCustomNumber, value);
		}

		[Ordinal(3)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetProperty(ref _customNumber);
			set => SetProperty(ref _customNumber, value);
		}
	}
}
