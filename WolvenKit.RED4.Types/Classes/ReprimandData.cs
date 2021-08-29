using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReprimandData : RedBaseClass
	{
		private CBool _isActive;
		private entEntityID _receiver;
		private CName _receiverAttitudeGroup;
		private CInt32 _reprimandID;
		private CInt32 _count;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(1)] 
		[RED("receiver")] 
		public entEntityID Receiver
		{
			get => GetProperty(ref _receiver);
			set => SetProperty(ref _receiver, value);
		}

		[Ordinal(2)] 
		[RED("receiverAttitudeGroup")] 
		public CName ReceiverAttitudeGroup
		{
			get => GetProperty(ref _receiverAttitudeGroup);
			set => SetProperty(ref _receiverAttitudeGroup, value);
		}

		[Ordinal(3)] 
		[RED("reprimandID")] 
		public CInt32 ReprimandID
		{
			get => GetProperty(ref _reprimandID);
			set => SetProperty(ref _reprimandID, value);
		}

		[Ordinal(4)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}
	}
}
