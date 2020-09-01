using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSlideToTargetDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(2)] [RED("("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		[Ordinal(4)] [RED("("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[Ordinal(5)] [RED("("adjustVertically")] 		public CBool AdjustVertically { get; set;}

		[Ordinal(6)] [RED("("rotateToTarget")] 		public CBool RotateToTarget { get; set;}

		[Ordinal(7)] [RED("("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBTTaskSlideToTargetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSlideToTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}