using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPropOwnershipTransferOptions : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnPropOwnershipTransferOptionsType> Type
		{
			get => GetPropertyValue<CEnum<scnPropOwnershipTransferOptionsType>>();
			set => SetPropertyValue<CEnum<scnPropOwnershipTransferOptionsType>>(value);
		}

		[Ordinal(1)] 
		[RED("dettachFromSlot")] 
		public CBool DettachFromSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("removeFromInventory")] 
		public CBool RemoveFromInventory
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnPropOwnershipTransferOptions()
		{
			DettachFromSlot = true;
			RemoveFromInventory = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
