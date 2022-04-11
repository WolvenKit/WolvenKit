using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFollowSlotDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public gamebbScriptID_Int32 SlotID
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("slotTransform")] 
		public gamebbScriptID_Variant SlotTransform
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public AIFollowSlotDef()
		{
			SlotID = new();
			SlotTransform = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
