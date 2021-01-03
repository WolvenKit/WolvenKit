using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FridgeControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("isOpen")] public CBool IsOpen { get; set; }

		public FridgeControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
