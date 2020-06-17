using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUnderwaterSwimInRandomDirectionDef : IBehTreeTaskDefinition
	{
		[RED("stayInGuardArea")] 		public CBool StayInGuardArea { get; set;}

		[RED("maxProximityToSurface")] 		public CFloat MaxProximityToSurface { get; set;}

		[RED("minimumWaterDepth")] 		public CFloat MinimumWaterDepth { get; set;}

		[RED("randomizeDirectionDelay")] 		public SRangeF RandomizeDirectionDelay { get; set;}

		public CBTTaskUnderwaterSwimInRandomDirectionDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskUnderwaterSwimInRandomDirectionDef(cr2w);

	}
}