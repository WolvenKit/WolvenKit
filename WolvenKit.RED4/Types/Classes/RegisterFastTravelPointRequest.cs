using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterFastTravelPointRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("pointData")] 
		public CHandle<gameFastTravelPointData> PointData
		{
			get => GetPropertyValue<CHandle<gameFastTravelPointData>>();
			set => SetPropertyValue<CHandle<gameFastTravelPointData>>(value);
		}

		[Ordinal(1)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public RegisterFastTravelPointRequest()
		{
			RequesterID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
