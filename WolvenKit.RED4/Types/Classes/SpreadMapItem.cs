using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpreadMapItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("key")] 
		public CWeakHandle<gamedataInteractionBase_Record> Key
		{
			get => GetPropertyValue<CWeakHandle<gamedataInteractionBase_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataInteractionBase_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SpreadMapItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
