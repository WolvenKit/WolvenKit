using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetDeviceInvestigationData : AIbehaviortaskScript
	{
		private CWeakHandle<ScriptedPuppet> _ownerPuppet;
		private CWeakHandle<gameObject> _listener;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public CWeakHandle<ScriptedPuppet> OwnerPuppet
		{
			get => GetProperty(ref _ownerPuppet);
			set => SetProperty(ref _ownerPuppet, value);
		}

		[Ordinal(1)] 
		[RED("listener")] 
		public CWeakHandle<gameObject> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}
	}
}
