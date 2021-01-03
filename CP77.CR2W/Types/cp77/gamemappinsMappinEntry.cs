using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinEntry : CVariable
	{
		[Ordinal(0)]  [RED("id")] public gameNewMappinID Id { get; set; }
		[Ordinal(1)]  [RED("type")] public CName Type { get; set; }
		[Ordinal(2)]  [RED("worldPosition")] public Vector4 WorldPosition { get; set; }

		public gamemappinsMappinEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
