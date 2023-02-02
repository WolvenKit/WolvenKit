using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameScanningControllerReplicatedState : ISerializable
	{
		[Ordinal(0)] 
		[RED("taggedObjectIDs")] 
		public CArray<entEntityID> TaggedObjectIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public gameScanningControllerReplicatedState()
		{
			TaggedObjectIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
