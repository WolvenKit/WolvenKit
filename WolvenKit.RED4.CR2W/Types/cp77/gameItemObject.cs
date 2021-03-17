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
			get => GetProperty(ref _updateBucket);
			set => SetProperty(ref _updateBucket, value);
		}

		[Ordinal(41)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get => GetProperty(ref _lootQuality);
			set => SetProperty(ref _lootQuality, value);
		}

		[Ordinal(42)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetProperty(ref _isIconic);
			set => SetProperty(ref _isIconic, value);
		}

		public gameItemObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
