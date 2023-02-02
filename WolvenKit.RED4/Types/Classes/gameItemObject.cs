using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameItemObject : gameTimeDilatable
	{
		[Ordinal(35)] 
		[RED("updateBucket")] 
		public CEnum<UpdateBucketEnum> UpdateBucket
		{
			get => GetPropertyValue<CEnum<UpdateBucketEnum>>();
			set => SetPropertyValue<CEnum<UpdateBucketEnum>>(value);
		}

		[Ordinal(36)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(37)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameItemObject()
		{
			UpdateBucket = Enums.UpdateBucketEnum.AttachedObject;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
