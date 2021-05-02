using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDModule : IScriptable
	{
		private wCHandle<HUDManager> _hud;
		private CEnum<ModuleState> _state;
		private CArray<CHandle<ModuleInstance>> _instancesList;

		[Ordinal(0)] 
		[RED("hud")] 
		public wCHandle<HUDManager> Hud
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

		public HUDModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
