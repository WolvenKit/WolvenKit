using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HUDModule : IScriptable
	{
		private CWeakHandle<HUDManager> _hud;
		private CEnum<ModuleState> _state;
		private CArray<CHandle<ModuleInstance>> _instancesList;

		[Ordinal(0)] 
		[RED("hud")] 
		public CWeakHandle<HUDManager> Hud
		{
			get => GetProperty(ref _hud);
			set => SetProperty(ref _hud, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<ModuleState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("instancesList")] 
		public CArray<CHandle<ModuleInstance>> InstancesList
		{
			get => GetProperty(ref _instancesList);
			set => SetProperty(ref _instancesList, value);
		}
	}
}
