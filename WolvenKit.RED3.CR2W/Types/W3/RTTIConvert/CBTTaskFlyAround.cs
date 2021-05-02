using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyAround : CBTTaskVolumetricMove
	{
		[Ordinal(1)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(2)] [RED("altitude")] 		public CFloat Altitude { get; set;}

		[Ordinal(3)] [RED("tolerance")] 		public CFloat Tolerance { get; set;}

		[Ordinal(4)] [RED("frontalHeadingOffset")] 		public CInt32 FrontalHeadingOffset { get; set;}

		[Ordinal(5)] [RED("landingGroundOffset")] 		public CFloat LandingGroundOffset { get; set;}

		[Ordinal(6)] [RED("randomHeight")] 		public CInt32 RandomHeight { get; set;}

		[Ordinal(7)] [RED("anchorPoint")] 		public CHandle<CEncounter> AnchorPoint { get; set;}

		[Ordinal(8)] [RED("anchorPointAC")] 		public CHandle<CAreaComponent> AnchorPointAC { get; set;}

		[Ordinal(9)] [RED("anchorPointPos")] 		public Vector AnchorPointPos { get; set;}

		[Ordinal(10)] [RED("anchorPointToNpcVector")] 		public Vector AnchorPointToNpcVector { get; set;}

		[Ordinal(11)] [RED("anchorPointToNpcHeight")] 		public CFloat AnchorPointToNpcHeight { get; set;}

		[Ordinal(12)] [RED("anchorPointToNpcDistance2D")] 		public CFloat AnchorPointToNpcDistance2D { get; set;}

		[Ordinal(13)] [RED("npcToDestVector")] 		public Vector NpcToDestVector { get; set;}

		[Ordinal(14)] [RED("npcToDestVector2")] 		public Vector NpcToDestVector2 { get; set;}

		[Ordinal(15)] [RED("npcToDestDistance")] 		public CFloat NpcToDestDistance { get; set;}

		[Ordinal(16)] [RED("npcToDestAngle")] 		public CFloat NpcToDestAngle { get; set;}

		[Ordinal(17)] [RED("flightMaxDuration")] 		public CFloat FlightMaxDuration { get; set;}

		[Ordinal(18)] [RED("flightStartTime")] 		public CFloat FlightStartTime { get; set;}

		[Ordinal(19)] [RED("flightDuration")] 		public CFloat FlightDuration { get; set;}

		public CBTTaskFlyAround(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}