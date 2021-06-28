using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_BriefingDef : gamebbScriptDefinition
	{
		private gamebbScriptID_String _briefingToOpen;
		private gamebbScriptID_Variant _briefingSize;
		private gamebbScriptID_Variant _briefingAlignment;

		[Ordinal(0)] 
		[RED("BriefingToOpen")] 
		public gamebbScriptID_String BriefingToOpen
		{
			get => GetProperty(ref _briefingToOpen);
			set => SetProperty(ref _briefingToOpen, value);
		}

		[Ordinal(1)] 
		[RED("BriefingSize")] 
		public gamebbScriptID_Variant BriefingSize
		{
			get => GetProperty(ref _briefingSize);
			set => SetProperty(ref _briefingSize, value);
		}

		[Ordinal(2)] 
		[RED("BriefingAlignment")] 
		public gamebbScriptID_Variant BriefingAlignment
		{
			get => GetProperty(ref _briefingAlignment);
			set => SetProperty(ref _briefingAlignment, value);
		}

		public UI_BriefingDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
