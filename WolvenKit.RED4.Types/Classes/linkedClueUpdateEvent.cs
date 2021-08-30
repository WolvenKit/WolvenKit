using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class linkedClueUpdateEvent : redEvent
	{
		private LinkedFocusClueData _linkedCluekData;
		private entEntityID _requesterID;
		private CBool _updatePS;

		[Ordinal(0)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get => GetProperty(ref _linkedCluekData);
			set => SetProperty(ref _linkedCluekData, value);
		}

		[Ordinal(1)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}

		[Ordinal(2)] 
		[RED("updatePS")] 
		public CBool UpdatePS
		{
			get => GetProperty(ref _updatePS);
			set => SetProperty(ref _updatePS, value);
		}

		public linkedClueUpdateEvent()
		{
			_updatePS = true;
		}
	}
}
