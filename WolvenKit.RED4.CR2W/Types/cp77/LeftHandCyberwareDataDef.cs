using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _projectileCaught;

		[Ordinal(0)] 
		[RED("ProjectileCaught")] 
		public gamebbScriptID_Bool ProjectileCaught
		{
			get => GetProperty(ref _projectileCaught);
			set => SetProperty(ref _projectileCaught, value);
		}

		public LeftHandCyberwareDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
