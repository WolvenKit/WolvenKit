using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEntityMapPinInfo : CVariable
	{
		[RED("entityName")] 		public CName EntityName { get; set;}

		[RED("entityCustomNameId")] 		public CUInt32 EntityCustomNameId { get; set;}

		[RED("entityTags")] 		public TagList EntityTags { get; set;}

		[RED("entityPosition")] 		public Vector EntityPosition { get; set;}

		[RED("entityRadius")] 		public CFloat EntityRadius { get; set;}

		[RED("entityType")] 		public CName EntityType { get; set;}

		[RED("alternateVersion")] 		public CInt32 AlternateVersion { get; set;}

		[RED("fastTravelSpotName")] 		public CName FastTravelSpotName { get; set;}

		[RED("fastTravelGroupName")] 		public CName FastTravelGroupName { get; set;}

		[RED("fastTravelTeleportWayPointTag")] 		public CName FastTravelTeleportWayPointTag { get; set;}

		[RED("fastTravelTeleportWayPointPosition")] 		public Vector FastTravelTeleportWayPointPosition { get; set;}

		[RED("fastTravelTeleportWayPointRotation")] 		public EulerAngles FastTravelTeleportWayPointRotation { get; set;}

		public SEntityMapPinInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEntityMapPinInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}