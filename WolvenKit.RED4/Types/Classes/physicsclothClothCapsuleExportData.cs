using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsclothClothCapsuleExportData : ISerializable
	{
		[Ordinal(0)] 
		[RED("capsules")] 
		public CArray<physicsclothExportedCapsule> Capsules
		{
			get => GetPropertyValue<CArray<physicsclothExportedCapsule>>();
			set => SetPropertyValue<CArray<physicsclothExportedCapsule>>(value);
		}

		public physicsclothClothCapsuleExportData()
		{
			Capsules = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
