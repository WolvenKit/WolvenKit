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
			get
			{
				if (_id == null)
				{
					_id = (gameItemID) CR2WTypeManager.Create("gameItemID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (CString) CR2WTypeManager.Create("String", "itemName", cr2w, this);
				}
				return _itemName;
			}
			set
			{
				if (_itemName == value)
				{
					return;
				}
				_itemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("categoryName")] 
		public CString CategoryName
		{
			get
			{
				if (_categoryName == null)
				{
					_categoryName = (CString) CR2WTypeManager.Create("String", "categoryName", cr2w, this);
				}
				return _categoryName;
			}
			set
			{
				if (_categoryName == value)
				{
					return;
				}
				_categoryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("quality")] 
		public CString Quality
		{
			get
			{
				if (_quality == null)
				{
					_quality = (CString) CR2WTypeManager.Create("String", "quality", cr2w, this);
				}
				return _quality;
			}
			set
			{
				if (_quality == value)
				{
					return;
				}
				_quality = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("price")] 
		public CFloat Price
		{
			get
			{
				if (_price == null)
				{
					_price = (CFloat) CR2WTypeManager.Create("Float", "price", cr2w, this);
				}
				return _price;
			}
			set
			{
				if (_price == value)
				{
					return;
				}
				_price = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get
			{
				if (_isBroken == null)
				{
					_isBroken = (CBool) CR2WTypeManager.Create("Bool", "isBroken", cr2w, this);
				}
				return _isBroken;
			}
			set
			{
				if (_isBroken == value)
				{
					return;
				}
				_isBroken = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("primaryStats")] 
		public CArray<gameStatViewData> PrimaryStats
		{
			get
			{
				if (_primaryStats == null)
				{
					_primaryStats = (CArray<gameStatViewData>) CR2WTypeManager.Create("array:gameStatViewData", "primaryStats", cr2w, this);
				}
				return _primaryStats;
			}
			set
			{
				if (_primaryStats == value)
				{
					return;
				}
				_primaryStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("secondaryStats")] 
		public CArray<gameStatViewData> SecondaryStats
		{
			get
			{
				if (_secondaryStats == null)
				{
					_secondaryStats = (CArray<gameStatViewData>) CR2WTypeManager.Create("array:gameStatViewData", "secondaryStats", cr2w, this);
				}
				return _secondaryStats;
			}
			set
			{
				if (_secondaryStats == value)
				{
					return;
				}
				_secondaryStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("comparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get
			{
				if (_comparedQuality == null)
				{
					_comparedQuality = (CEnum<gamedataQuality>) CR2WTypeManager.Create("gamedataQuality", "comparedQuality", cr2w, this);
				}
				return _comparedQuality;
			}
			set
			{
				if (_comparedQuality == value)
				{
					return;
				}
				_comparedQuality = value;
				PropertySet(this);
			}
		}

		public gameItemViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
