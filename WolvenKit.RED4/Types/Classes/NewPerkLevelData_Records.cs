using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkLevelData_Records : BasePerkLevelData_Records
	{
		[Ordinal(0)] 
		[RED("perkRecord")] 
		public CWeakHandle<gamedataNewPerk_Record> PerkRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataNewPerk_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataNewPerk_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("arr")] 
		public CArray<CWeakHandle<gamedataNewPerkLevelData_Record>> Arr
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataNewPerkLevelData_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataNewPerkLevelData_Record>>>(value);
		}

		public NewPerkLevelData_Records()
		{
			Arr = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
