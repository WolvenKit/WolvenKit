using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameGodModeSaveData : ISerializable
	{
		[Ordinal(0)]  [RED("gods")] public CArray<gameGodModeSaveEntityData> Gods { get; set; }

		public gameGodModeSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
