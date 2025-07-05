using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharactersChain : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rarities")] 
		public CArray<CUInt32> Rarities
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(1)] 
		[RED("matchedValues")] 
		public CUInt32 MatchedValues
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("ownerId")] 
		public CInt32 OwnerId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("isFulfilled")] 
		public CBool IsFulfilled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isPossible")] 
		public CBool IsPossible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiCharactersChain()
		{
			Rarities = new();
			OwnerId = -1;
			IsPossible = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
