using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemViewData : CVariable
	{
		private gameItemID _id;
		private CString _itemName;
		private CString _categoryName;
		private CString _description;
		private CString _quality;
		private CFloat _price;
		private CBool _isBroken;
		private CArray<gameStatViewData> _primaryStats;
		private CArray<gameStatViewData> _secondaryStats;
		private CEnum<gamedataQuality> _comparedQuality;

		[Ordinal(0)] 
		[RED("id")] 
		public gameItemID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(2)] 
		[RED("categoryName")] 
		public CString CategoryName
		{
			get => GetProperty(ref _categoryName);
			set => SetProperty(ref _categoryName, value);
		}

		[Ordinal(3)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(4)] 
		[RED("quality")] 
		public CString Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(5)] 
		[RED("price")] 
		public CFloat Price
		{
			get => GetProperty(ref _price);
			set => SetProperty(ref _price, value);
		}

		[Ordinal(6)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetProperty(ref _isBroken);
			set => SetProperty(ref _isBroken, value);
		}

		[Ordinal(7)] 
		[RED("primaryStats")] 
		public CArray<gameStatViewData> PrimaryStats
		{
			get => GetProperty(ref _primaryStats);
			set => SetProperty(ref _primaryStats, value);
		}

		[Ordinal(8)] 
		[RED("secondaryStats")] 
		public CArray<gameStatViewData> SecondaryStats
		{
			get => GetProperty(ref _secondaryStats);
			set => SetProperty(ref _secondaryStats, value);
		}

		[Ordinal(9)] 
		[RED("comparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get => GetProperty(ref _comparedQuality);
			set => SetProperty(ref _comparedQuality, value);
		}

		public gameItemViewData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
