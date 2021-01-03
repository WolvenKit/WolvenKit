using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class JukeboxBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("IsPlaying")] public gamebbScriptID_Bool IsPlaying { get; set; }

		public JukeboxBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
