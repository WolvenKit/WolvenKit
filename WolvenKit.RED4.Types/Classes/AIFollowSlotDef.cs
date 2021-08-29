using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFollowSlotDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _slotID;
		private gamebbScriptID_Variant _slotTransform;

		[Ordinal(0)] 
		[RED("slotID")] 
		public gamebbScriptID_Int32 SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("slotTransform")] 
		public gamebbScriptID_Variant SlotTransform
		{
			get => GetProperty(ref _slotTransform);
			set => SetProperty(ref _slotTransform, value);
		}
	}
}
