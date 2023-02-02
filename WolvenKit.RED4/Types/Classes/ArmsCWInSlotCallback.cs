using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArmsCWInSlotCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("state")] 
		public CWeakHandle<ArmsCWInSlotPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<ArmsCWInSlotPrereqState>>();
			set => SetPropertyValue<CWeakHandle<ArmsCWInSlotPrereqState>>(value);
		}

		public ArmsCWInSlotCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
