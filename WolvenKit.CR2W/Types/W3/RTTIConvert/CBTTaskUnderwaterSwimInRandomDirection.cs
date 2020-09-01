using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
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

		public CBTTaskUnderwaterSwimInRandomDirection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUnderwaterSwimInRandomDirection(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}