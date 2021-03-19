using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIWorldBoundariesDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isPlayerCloseToBoundary;
		private gamebbScriptID_Bool _isPlayerGoingDeeper;

		[Ordinal(0)] 
		[RED("IsPlayerCloseToBoundary")] 
		public gamebbScriptID_Bool IsPlayerCloseToBoundary
		{
			get => GetProperty(ref _isPlayerCloseToBoundary);
			set => SetProperty(ref _isPlayerCloseToBoundary, value);
		}

		[Ordinal(1)] 
		[RED("IsPlayerGoingDeeper")] 
		public gamebbScriptID_Bool IsPlayerGoingDeeper
		{
			get => GetProperty(ref _isPlayerGoingDeeper);
			set => SetProperty(ref _isPlayerGoingDeeper, value);
		}

		public UIWorldBoundariesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
