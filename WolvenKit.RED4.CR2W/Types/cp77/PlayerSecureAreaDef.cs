using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerSecureAreaDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _inside;

		[Ordinal(0)] 
		[RED("inside")] 
		public gamebbScriptID_Bool Inside
		{
			get => GetProperty(ref _inside);
			set => SetProperty(ref _inside, value);
		}

		public PlayerSecureAreaDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
