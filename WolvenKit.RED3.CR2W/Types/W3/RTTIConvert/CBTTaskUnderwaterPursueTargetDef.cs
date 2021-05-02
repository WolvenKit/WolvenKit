using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUnderwaterPursueTargetDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("useCustom")] 		public CBool UseCustom { get; set;}

		[Ordinal(2)] [RED("distanceFromTarget")] 		public CFloat DistanceFromTarget { get; set;}

		[Ordinal(3)] [RED("heightFromTarget")] 		public CFloat HeightFromTarget { get; set;}

		[Ordinal(4)] [RED("distanceTolerance")] 		public CFloat DistanceTolerance { get; set;}

		[Ordinal(5)] [RED("randomHeight")] 		public CInt32 RandomHeight { get; set;}

		public CBTTaskUnderwaterPursueTargetDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUnderwaterPursueTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}