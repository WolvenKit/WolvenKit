using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UniqueRangedWeaponPSMPrereqState : PlayerStateMachinePrereqState
	{
		[Ordinal(3)] 
		[RED("listenedID")] 
		public gamebbScriptID_Int32 ListenedID
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public UniqueRangedWeaponPSMPrereqState()
		{
			ListenedID = new gamebbScriptID_Int32();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
