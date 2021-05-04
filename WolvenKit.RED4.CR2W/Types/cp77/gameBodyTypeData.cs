using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBodyTypeData : CVariable
	{
		private CUInt64 _rigHash;
		private CArray<CUInt64> _animsetHashes;
		private CArray<gameAnimsetOverrideData> _overrides;

		[Ordinal(0)] 
		[RED("rigHash")] 
		public CUInt64 RigHash
		{
			get => GetProperty(ref _rigHash);
			set => SetProperty(ref _rigHash, value);
		}

		[Ordinal(1)] 
		[RED("animsetHashes")] 
		public CArray<CUInt64> AnimsetHashes
		{
			get => GetProperty(ref _animsetHashes);
			set => SetProperty(ref _animsetHashes, value);
		}

		[Ordinal(2)] 
		[RED("overrides")] 
		public CArray<gameAnimsetOverrideData> Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}

		public gameBodyTypeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
