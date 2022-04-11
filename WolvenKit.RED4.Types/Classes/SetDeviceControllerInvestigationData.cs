using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetDeviceControllerInvestigationData : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public CWeakHandle<ScriptedPuppet> OwnerPuppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}
	}
}
