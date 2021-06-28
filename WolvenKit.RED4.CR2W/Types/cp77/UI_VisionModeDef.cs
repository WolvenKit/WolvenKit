using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_VisionModeDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isEnabled;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public gamebbScriptID_Bool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public UI_VisionModeDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
