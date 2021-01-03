using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ConfessionalBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("IsConfessing")] public gamebbScriptID_Bool IsConfessing { get; set; }

		public ConfessionalBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
