using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSlideToTargetDef : IBehTreeTaskDefinition
	{
		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		[RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[RED("adjustVertically")] 		public CBool AdjustVertically { get; set;}

		[RED("rotateToTarget")] 		public CBool RotateToTarget { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBTTaskSlideToTargetDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSlideToTargetDef(cr2w);

	}
}