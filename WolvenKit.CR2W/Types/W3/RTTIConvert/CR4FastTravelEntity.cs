using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4FastTravelEntity : CR4MapPinEntity
	{
		[RED("spotName")] 		public CName SpotName { get; set;}

		[RED("groupName")] 		public CName GroupName { get; set;}

		[RED("teleportWayPointTag")] 		public CName TeleportWayPointTag { get; set;}

		[RED("canBeReachedByBoat")] 		public CBool CanBeReachedByBoat { get; set;}

		[RED("isHubExit")] 		public CBool IsHubExit { get; set;}

		public CR4FastTravelEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4FastTravelEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}