using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningControllerReplicatedState : ISerializable
	{
		private CArray<entEntityID> _taggedObjectIDs;

		[Ordinal(0)] 
		[RED("taggedObjectIDs")] 
		public CArray<entEntityID> TaggedObjectIDs
		{
			get => GetProperty(ref _taggedObjectIDs);
			set => SetProperty(ref _taggedObjectIDs, value);
		}

		public gameScanningControllerReplicatedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
