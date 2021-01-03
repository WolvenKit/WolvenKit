using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ForkliftControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("forkliftSetup")] public ForkliftSetup ForkliftSetup { get; set; }
		[Ordinal(1)]  [RED("isUp")] public CBool IsUp { get; set; }

		public ForkliftControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
