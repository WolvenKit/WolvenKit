using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_WantedBarDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _currentBounty;
		private gamebbScriptID_Int32 _currentWantedLevel;

		[Ordinal(0)] 
		[RED("CurrentBounty")] 
		public gamebbScriptID_Int32 CurrentBounty
		{
			get => GetProperty(ref _currentBounty);
			set => SetProperty(ref _currentBounty, value);
		}

		[Ordinal(1)] 
		[RED("CurrentWantedLevel")] 
		public gamebbScriptID_Int32 CurrentWantedLevel
		{
			get => GetProperty(ref _currentWantedLevel);
			set => SetProperty(ref _currentWantedLevel, value);
		}

		public UI_WantedBarDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
