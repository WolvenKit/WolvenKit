using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameItemViewData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public gameItemID Id
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("categoryName")] 
		public CString CategoryName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("quality")] 
		public CString Quality
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("price")] 
		public CFloat Price
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("primaryStats")] 
		public CArray<gameStatViewData> PrimaryStats
		{
			get => GetPropertyValue<CArray<gameStatViewData>>();
			set => SetPropertyValue<CArray<gameStatViewData>>(value);
		}

		[Ordinal(8)] 
		[RED("secondaryStats")] 
		public CArray<gameStatViewData> SecondaryStats
		{
			get => GetPropertyValue<CArray<gameStatViewData>>();
			set => SetPropertyValue<CArray<gameStatViewData>>(value);
		}

		[Ordinal(9)] 
		[RED("comparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		public gameItemViewData()
		{
			Id = new gameItemID();
			PrimaryStats = new();
			SecondaryStats = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
