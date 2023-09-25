using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleCanSwapWeapons : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("result")] 
		public CBool Result
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>> Items
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>>>(value);
		}

		public SimpleCanSwapWeapons()
		{
			Items = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
