using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlaceMineEvent : redEvent
	{
		[Ordinal(0)]  [RED("normal")] public Vector4 Normal { get; set; }
		[Ordinal(1)]  [RED("position")] public Vector4 Position { get; set; }

		public PlaceMineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
