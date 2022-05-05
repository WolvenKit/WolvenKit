using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftItemRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("itemRecord")] 
		public CHandle<gamedataItem_Record> ItemRecord
		{
			get => GetPropertyValue<CHandle<gamedataItem_Record>>();
			set => SetPropertyValue<CHandle<gamedataItem_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("bulletAmount")] 
		public CInt32 BulletAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public CraftItemRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
