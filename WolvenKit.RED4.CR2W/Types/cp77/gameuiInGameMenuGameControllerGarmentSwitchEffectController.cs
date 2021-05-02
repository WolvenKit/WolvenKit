using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInGameMenuGameControllerGarmentSwitchEffectController : CVariable
	{
		private CName _sceneName;
		private CName _effectName;

		[Ordinal(0)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetProperty(ref _sceneName);
			set => SetProperty(ref _sceneName, value);
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		public gameuiInGameMenuGameControllerGarmentSwitchEffectController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
