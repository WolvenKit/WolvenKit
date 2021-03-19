using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinesDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Vector4 _currentNormal;

		[Ordinal(0)] 
		[RED("CurrentNormal")] 
		public gamebbScriptID_Vector4 CurrentNormal
		{
			get => GetProperty(ref _currentNormal);
			set => SetProperty(ref _currentNormal, value);
		}

		public MinesDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
