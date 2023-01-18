using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformsSavedState : ISerializable
	{
		[Ordinal(0)] 
		[RED("mapping")] 
		public CArray<entEntityID> Mapping
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CArray<gameMovingPlatformSavedData> Data
		{
			get => GetPropertyValue<CArray<gameMovingPlatformSavedData>>();
			set => SetPropertyValue<CArray<gameMovingPlatformSavedData>>(value);
		}

		public gameMovingPlatformsSavedState()
		{
			Mapping = new();
			Data = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
