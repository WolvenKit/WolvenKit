using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ChatBoxDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _textList;

		[Ordinal(0)] 
		[RED("TextList")] 
		public gamebbScriptID_Variant TextList
		{
			get => GetProperty(ref _textList);
			set => SetProperty(ref _textList, value);
		}

		public UI_ChatBoxDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
