using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformsSavedState : ISerializable
	{
		[Ordinal(0)]  [RED("data")] public CArray<gameMovingPlatformSavedData> Data { get; set; }
		[Ordinal(1)]  [RED("mapping")] public CArray<entEntityID> Mapping { get; set; }

		public gameMovingPlatformsSavedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
