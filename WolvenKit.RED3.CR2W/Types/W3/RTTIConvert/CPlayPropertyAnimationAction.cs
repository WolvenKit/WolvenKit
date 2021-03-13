using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPlayPropertyAnimationAction : IEntityTargetingAction
	{
		[Ordinal(1)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(2)] [RED("loopCount")] 		public CUInt32 LoopCount { get; set;}

		[Ordinal(3)] [RED("lengthScale")] 		public CFloat LengthScale { get; set;}

		[Ordinal(4)] [RED("mode")] 		public CEnum<EPropertyCurveMode> Mode { get; set;}

		public CPlayPropertyAnimationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlayPropertyAnimationAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}