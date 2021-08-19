using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputContextTransitionEvents : DefaultTransition
	{
		private wCHandle<GameplaySettingsSystem> _gameplaySettings;

		[Ordinal(0)] 
		[RED("gameplaySettings")] 
		public wCHandle<GameplaySettingsSystem> GameplaySettings
		{
			get => GetProperty(ref _gameplaySettings);
			set => SetProperty(ref _gameplaySettings, value);
		}

		public InputContextTransitionEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
