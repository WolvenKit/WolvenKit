using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_FastForwardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _fastForwardAvailable;
		private gamebbScriptID_Bool _fastForwardActive;

		[Ordinal(0)] 
		[RED("FastForwardAvailable")] 
		public gamebbScriptID_Bool FastForwardAvailable
		{
			get => GetProperty(ref _fastForwardAvailable);
			set => SetProperty(ref _fastForwardAvailable, value);
		}

		[Ordinal(1)] 
		[RED("FastForwardActive")] 
		public gamebbScriptID_Bool FastForwardActive
		{
			get => GetProperty(ref _fastForwardActive);
			set => SetProperty(ref _fastForwardActive, value);
		}

		public UI_FastForwardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
