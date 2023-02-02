using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateFastTravelPointRecordRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("pointRecord")] 
		public TweakDBID PointRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public UpdateFastTravelPointRecordRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
