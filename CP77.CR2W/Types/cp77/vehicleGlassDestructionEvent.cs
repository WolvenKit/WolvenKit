using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleGlassDestructionEvent : redEvent
	{
		[Ordinal(0)]  [RED("glassName")] public CName GlassName { get; set; }

		public vehicleGlassDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
