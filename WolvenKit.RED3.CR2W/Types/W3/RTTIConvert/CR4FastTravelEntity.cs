using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4FastTravelEntity : CR4MapPinEntity
	{
		[Ordinal(1)] [RED("spotName")] 		public CName SpotName { get; set;}

		[Ordinal(2)] [RED("groupName")] 		public CName GroupName { get; set;}

		[Ordinal(3)] [RED("teleportWayPointTag")] 		public CName TeleportWayPointTag { get; set;}

		[Ordinal(4)] [RED("canBeReachedByBoat")] 		public CBool CanBeReachedByBoat { get; set;}

		[Ordinal(5)] [RED("isHubExit")] 		public CBool IsHubExit { get; set;}

		public CR4FastTravelEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}