using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemObject : gameTimeDilatable
	{
		private CEnum<UpdateBucketEnum> _updateBucket;
		private CEnum<gamedataQuality> _lootQuality;
		private CBool _isIconic;

		[Ordinal(40)] 
		[RED("updateBucket")] 
		public CEnum<UpdateBucketEnum> UpdateBucket
		{
			get
			{
				if (_updateBucket == null)
				{
					_updateBucket = (CEnum<UpdateBucketEnum>) CR2WTypeManager.Create("UpdateBucketEnum", "updateBucket", cr2w, this);
				}
				return _updateBucket;
			}
			set
			{
				if (_updateBucket == value)
				{
					return;
				}
				_updateBucket = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get
			{
				if (_lootQuality == null)
				{
					_lootQuality = (CEnum<gamedataQuality>) CR2WTypeManager.Create("gamedataQuality", "lootQuality", cr2w, this);
				}
				return _lootQuality;
			}
			set
			{
				if (_lootQuality == value)
				{
					return;
				}
				_lootQuality = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get
			{
				if (_isIconic == null)
				{
					_isIconic = (CBool) CR2WTypeManager.Create("Bool", "isIconic", cr2w, this);
				}
				return _isIconic;
			}
			set
			{
				if (_isIconic == value)
				{
					return;
				}
				_isIconic = value;
				PropertySet(this);
			}
		}

		public gameItemObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
