using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateFastTravelPointRecordRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("markerRef")] 
		public NodeRef MarkerRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public UpdateFastTravelPointRecordRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
