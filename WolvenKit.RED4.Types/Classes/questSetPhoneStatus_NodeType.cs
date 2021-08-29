using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetPhoneStatus_NodeType : questIPhoneManagerNodeType
	{
		private CEnum<questPhoneStatus> _status;
		private CName _customStatus;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<questPhoneStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(1)] 
		[RED("customStatus")] 
		public CName CustomStatus
		{
			get => GetProperty(ref _customStatus);
			set => SetProperty(ref _customStatus, value);
		}
	}
}
