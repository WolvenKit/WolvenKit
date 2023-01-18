using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navLocomotionPathResource : CResource
	{
		[Ordinal(1)] 
		[RED("paths")] 
		public CArray<CHandle<navLocomotionPath>> Paths
		{
			get => GetPropertyValue<CArray<CHandle<navLocomotionPath>>>();
			set => SetPropertyValue<CArray<CHandle<navLocomotionPath>>>(value);
		}

		public navLocomotionPathResource()
		{
			Paths = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
