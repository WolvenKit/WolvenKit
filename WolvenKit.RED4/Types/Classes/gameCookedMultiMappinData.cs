using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCookedMultiMappinData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("journalPathHash")] 
		public CUInt32 JournalPathHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("positions")] 
		public CArray<Vector3> Positions
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		public gameCookedMultiMappinData()
		{
			Positions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
