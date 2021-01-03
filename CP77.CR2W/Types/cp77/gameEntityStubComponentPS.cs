using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEntityStubComponentPS : gameComponentPS
	{
		[Ordinal(0)]  [RED("entityLocalPosition")] public Vector3 EntityLocalPosition { get; set; }
		[Ordinal(1)]  [RED("entityLocalRotation")] public Quaternion EntityLocalRotation { get; set; }
		[Ordinal(2)]  [RED("ownerCommunityEntryName")] public CName OwnerCommunityEntryName { get; set; }
		[Ordinal(3)]  [RED("selectedAppearanceName")] public CName SelectedAppearanceName { get; set; }
		[Ordinal(4)]  [RED("spawnerId")] public gameCommunityID SpawnerId { get; set; }

		public gameEntityStubComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
