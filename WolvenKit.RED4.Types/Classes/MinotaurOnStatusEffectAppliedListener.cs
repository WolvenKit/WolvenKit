using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinotaurOnStatusEffectAppliedListener : gameScriptStatusEffectListener
	{
		private CWeakHandle<NPCPuppet> _owner;
		private CHandle<MinotaurMechComponent> _minotaurMechComponent;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("minotaurMechComponent")] 
		public CHandle<MinotaurMechComponent> MinotaurMechComponent
		{
			get => GetProperty(ref _minotaurMechComponent);
			set => SetProperty(ref _minotaurMechComponent, value);
		}
	}
}
