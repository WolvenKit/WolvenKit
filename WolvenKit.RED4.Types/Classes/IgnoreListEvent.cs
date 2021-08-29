using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IgnoreListEvent : redEvent
	{
		private entEntityID _bodyID;
		private CBool _removeEvent;

		[Ordinal(0)] 
		[RED("bodyID")] 
		public entEntityID BodyID
		{
			get => GetProperty(ref _bodyID);
			set => SetProperty(ref _bodyID, value);
		}

		[Ordinal(1)] 
		[RED("removeEvent")] 
		public CBool RemoveEvent
		{
			get => GetProperty(ref _removeEvent);
			set => SetProperty(ref _removeEvent, value);
		}
	}
}
