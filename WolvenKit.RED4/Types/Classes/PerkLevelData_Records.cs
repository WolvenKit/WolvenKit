using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkLevelData_Records : BasePerkLevelData_Records
	{
		[Ordinal(0)] 
		[RED("arr")] 
		public CArray<CWeakHandle<gamedataPerkLevelData_Record>> Arr
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataPerkLevelData_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataPerkLevelData_Record>>>(value);
		}

		public PerkLevelData_Records()
		{
			Arr = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
