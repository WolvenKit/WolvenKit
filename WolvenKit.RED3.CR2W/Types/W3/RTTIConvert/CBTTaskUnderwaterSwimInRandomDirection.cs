using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUnderwaterSwimInRandomDirection : CBTTaskVolumetricMove
	{
		[Ordinal(1)] [RED("stayInGuardArea")] 		public CBool StayInGuardArea { get; set;}

		[Ordinal(2)] [RED("maxProximityToSurface")] 		public CFloat MaxProximityToSurface { get; set;}

		[Ordinal(3)] [RED("minimumWaterDepth")] 		public CFloat MinimumWaterDepth { get; set;}

		[Ordinal(4)] [RED("randomizeDirectionDelay")] 		public SRangeF RandomizeDirectionDelay { get; set;}

		[Ordinal(5)] [RED("m_destinationDistance")] 		public CFloat M_destinationDistance { get; set;}

		public CBTTaskUnderwaterSwimInRandomDirection(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}