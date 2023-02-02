using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDropItemFromSlot_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("useGravity")] 
		public CBool UseGravity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questDropItemFromSlot_NodeTypeParams()
		{
			ObjectRef = new() { Names = new() };
			UseGravity = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
