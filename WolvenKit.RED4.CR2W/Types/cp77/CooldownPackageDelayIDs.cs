using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownPackageDelayIDs : CVariable
	{
		private CooldownStorageID _packageID;
		private CArray<gameDelayID> _delayIDs;

		[Ordinal(0)] 
		[RED("packageID")] 
		public CooldownStorageID PackageID
		{
			get => GetProperty(ref _packageID);
			set => SetProperty(ref _packageID, value);
		}

		[Ordinal(1)] 
		[RED("delayIDs")] 
		public CArray<gameDelayID> DelayIDs
		{
			get => GetProperty(ref _delayIDs);
			set => SetProperty(ref _delayIDs, value);
		}

		public CooldownPackageDelayIDs(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
