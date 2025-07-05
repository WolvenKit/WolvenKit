using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleApplyZOffsetFromGroundEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("sampleNavmesh")] 
		public CBool SampleNavmesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleApplyZOffsetFromGroundEvent()
		{
			SampleNavmesh = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
