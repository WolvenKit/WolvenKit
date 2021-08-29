using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningControllerReplicatedState : ISerializable
	{
		private CArray<entEntityID> _taggedObjectIDs;

		[Ordinal(0)] 
		[RED("taggedObjectIDs")] 
		public CArray<entEntityID> TaggedObjectIDs
		{
			get => GetProperty(ref _taggedObjectIDs);
			set => SetProperty(ref _taggedObjectIDs, value);
		}
	}
}
