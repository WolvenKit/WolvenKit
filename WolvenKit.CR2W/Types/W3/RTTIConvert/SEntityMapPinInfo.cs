using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEntityMapPinInfo : CVariable
	{
		[Ordinal(0)] [RED("("entityName")] 		public CName EntityName { get; set;}

		[Ordinal(0)] [RED("("entityCustomNameId")] 		public CUInt32 EntityCustomNameId { get; set;}

		[Ordinal(0)] [RED("("entityTags")] 		public TagList EntityTags { get; set;}

		[Ordinal(0)] [RED("("entityPosition")] 		public Vector EntityPosition { get; set;}

		[Ordinal(0)] [RED("("entityRadius")] 		public CFloat EntityRadius { get; set;}

		[Ordinal(0)] [RED("("entityType")] 		public CName EntityType { get; set;}

		[Ordinal(0)] [RED("("alternateVersion")] 		public CInt32 AlternateVersion { get; set;}

		[Ordinal(0)] [RED("("fastTravelSpotName")] 		public CName FastTravelSpotName { get; set;}

		[Ordinal(0)] [RED("("fastTravelGroupName")] 		public CName FastTravelGroupName { get; set;}

		[Ordinal(0)] [RED("("fastTravelTeleportWayPointTag")] 		public CName FastTravelTeleportWayPointTag { get; set;}

		[Ordinal(0)] [RED("("fastTravelTeleportWayPointPosition")] 		public Vector FastTravelTeleportWayPointPosition { get; set;}

		[Ordinal(0)] [RED("("fastTravelTeleportWayPointRotation")] 		public EulerAngles FastTravelTeleportWayPointRotation { get; set;}

		public SEntityMapPinInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEntityMapPinInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}