using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CommunicationEvent : redEvent
	{
		private CName _name;
		private entEntityID _sender;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("sender")] 
		public entEntityID Sender
		{
			get => GetProperty(ref _sender);
			set => SetProperty(ref _sender, value);
		}
	}
}
