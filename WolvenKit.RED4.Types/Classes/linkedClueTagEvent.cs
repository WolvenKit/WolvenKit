using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class linkedClueTagEvent : redEvent
	{
		private CBool _tag;
		private entEntityID _requesterID;

		[Ordinal(0)] 
		[RED("tag")] 
		public CBool Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}
	}
}
