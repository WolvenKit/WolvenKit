using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class linkedClueTagEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CBool Tag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public linkedClueTagEvent()
		{
			RequesterID = new();
		}
	}
}
