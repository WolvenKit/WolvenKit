using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReprimandData : CVariable
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

		public ReprimandData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
