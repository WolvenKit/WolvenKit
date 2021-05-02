using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectMembershipMemberShip : CVariable
	{
		private CUInt64 _hash;
		private CUInt32 _index;

		[Ordinal(0)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(1)] 
		[RED("index")] 
		public CUInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		public gameSmartObjectMembershipMemberShip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
