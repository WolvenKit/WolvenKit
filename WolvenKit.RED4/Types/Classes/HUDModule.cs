using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class HUDModule : IScriptable
	{
		[Ordinal(0)] 
		[RED("hud")] 
		public CWeakHandle<HUDManager> Hud
		{
			get => GetPropertyValue<CWeakHandle<HUDManager>>();
			set => SetPropertyValue<CWeakHandle<HUDManager>>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<ModuleState> State
		{
			get => GetPropertyValue<CEnum<ModuleState>>();
			set => SetPropertyValue<CEnum<ModuleState>>(value);
		}

		[Ordinal(2)] 
		[RED("instancesList")] 
		public CArray<CHandle<ModuleInstance>> InstancesList
		{
			get => GetPropertyValue<CArray<CHandle<ModuleInstance>>>();
			set => SetPropertyValue<CArray<CHandle<ModuleInstance>>>(value);
		}

		public HUDModule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
