using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaminaPoolListener : gameScriptStatPoolsListener
	{
		private wCHandle<StaminabarWidgetGameController> _staminaBar;

		[Ordinal(0)] 
		[RED("staminaBar")] 
		public wCHandle<StaminabarWidgetGameController> StaminaBar
		{
			get => GetProperty(ref _staminaBar);
			set => SetProperty(ref _staminaBar, value);
		}

		public StaminaPoolListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
