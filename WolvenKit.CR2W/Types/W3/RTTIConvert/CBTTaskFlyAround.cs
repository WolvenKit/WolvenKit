using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyAround : CBTTaskVolumetricMove
	{
		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("altitude")] 		public CFloat Altitude { get; set;}

		[RED("tolerance")] 		public CFloat Tolerance { get; set;}

		[RED("frontalHeadingOffset")] 		public CInt32 FrontalHeadingOffset { get; set;}

		[RED("landingGroundOffset")] 		public CFloat LandingGroundOffset { get; set;}

		[RED("randomHeight")] 		public CInt32 RandomHeight { get; set;}

		[RED("anchorPoint")] 		public CHandle<CEncounter> AnchorPoint { get; set;}

		[RED("anchorPointAC")] 		public CHandle<CAreaComponent> AnchorPointAC { get; set;}

		[RED("anchorPointPos")] 		public Vector AnchorPointPos { get; set;}

		[RED("anchorPointToNpcVector")] 		public Vector AnchorPointToNpcVector { get; set;}

		[RED("anchorPointToNpcHeight")] 		public CFloat AnchorPointToNpcHeight { get; set;}

		[RED("anchorPointToNpcDistance2D")] 		public CFloat AnchorPointToNpcDistance2D { get; set;}

		[RED("npcToDestVector")] 		public Vector NpcToDestVector { get; set;}

		[RED("npcToDestVector2")] 		public Vector NpcToDestVector2 { get; set;}

		[RED("npcToDestDistance")] 		public CFloat NpcToDestDistance { get; set;}

		[RED("npcToDestAngle")] 		public CFloat NpcToDestAngle { get; set;}

		[RED("flightMaxDuration")] 		public CFloat FlightMaxDuration { get; set;}

		[RED("flightStartTime")] 		public CFloat FlightStartTime { get; set;}

		[RED("flightDuration")] 		public CFloat FlightDuration { get; set;}

		public CBTTaskFlyAround(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyAround(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}