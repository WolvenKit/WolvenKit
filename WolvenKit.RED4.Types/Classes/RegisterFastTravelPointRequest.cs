using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterFastTravelPointRequest : gameScriptableSystemRequest
	{
		private CHandle<gameFastTravelPointData> _pointData;
		private entEntityID _requesterID;

		[Ordinal(0)] 
		[RED("pointData")] 
		public CHandle<gameFastTravelPointData> PointData
		{
			get => GetProperty(ref _pointData);
			set => SetProperty(ref _pointData, value);
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
