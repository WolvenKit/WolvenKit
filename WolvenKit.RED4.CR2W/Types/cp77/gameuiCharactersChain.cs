using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharactersChain : CVariable
	{
		private CArray<CUInt32> _rarities;
		private CUInt32 _matchedValues;
		private CInt32 _ownerId;
		private CBool _isFulfilled;
		private CBool _isPossible;

		[Ordinal(0)] 
		[RED("rarities")] 
		public CArray<CUInt32> Rarities
		{
			get => GetProperty(ref _rarities);
			set => SetProperty(ref _rarities, value);
		}

		[Ordinal(1)] 
		[RED("matchedValues")] 
		public CUInt32 MatchedValues
		{
			get => GetProperty(ref _matchedValues);
			set => SetProperty(ref _matchedValues, value);
		}

		[Ordinal(2)] 
		[RED("ownerId")] 
		public CInt32 OwnerId
		{
			get => GetProperty(ref _ownerId);
			set => SetProperty(ref _ownerId, value);
		}

		[Ordinal(3)] 
		[RED("isFulfilled")] 
		public CBool IsFulfilled
		{
			get => GetProperty(ref _isFulfilled);
			set => SetProperty(ref _isFulfilled, value);
		}

		[Ordinal(4)] 
		[RED("isPossible")] 
		public CBool IsPossible
		{
			get => GetProperty(ref _isPossible);
			set => SetProperty(ref _isPossible, value);
		}

		public gameuiCharactersChain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
