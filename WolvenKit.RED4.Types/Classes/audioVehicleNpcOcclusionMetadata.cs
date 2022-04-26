using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleNpcOcclusionMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("void")] 
		public CBool Void
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioVehicleNpcOcclusionMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
