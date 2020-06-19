using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPlayPropertyAnimationAction : IEntityTargetingAction
	{
		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("loopCount")] 		public CUInt32 LoopCount { get; set;}

		[RED("lengthScale")] 		public CFloat LengthScale { get; set;}

		[RED("mode")] 		public CEnum<EPropertyCurveMode> Mode { get; set;}

		public CPlayPropertyAnimationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlayPropertyAnimationAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}