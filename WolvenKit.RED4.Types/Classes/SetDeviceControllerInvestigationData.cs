using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetDeviceControllerInvestigationData : AIbehaviortaskScript
	{
		private CWeakHandle<ScriptedPuppet> _ownerPuppet;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public CWeakHandle<ScriptedPuppet> OwnerPuppet
		{
			get => GetProperty(ref _ownerPuppet);
			set => SetProperty(ref _ownerPuppet, value);
		}
	}
}
