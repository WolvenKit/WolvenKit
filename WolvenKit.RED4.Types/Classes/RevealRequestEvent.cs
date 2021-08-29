using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevealRequestEvent : redEvent
	{
		private CBool _shouldReveal;
		private entEntityID _requester;
		private CBool _oneFrame;

		[Ordinal(0)] 
		[RED("shouldReveal")] 
		public CBool ShouldReveal
		{
			get => GetProperty(ref _shouldReveal);
			set => SetProperty(ref _shouldReveal, value);
		}

		[Ordinal(1)] 
		[RED("requester")] 
		public entEntityID Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(2)] 
		[RED("oneFrame")] 
		public CBool OneFrame
		{
			get => GetProperty(ref _oneFrame);
			set => SetProperty(ref _oneFrame, value);
		}
	}
}
