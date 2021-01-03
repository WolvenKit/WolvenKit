using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamebbScriptID_Vector4 : gamebbScriptID
	{

		public gamebbScriptID_Vector4(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
