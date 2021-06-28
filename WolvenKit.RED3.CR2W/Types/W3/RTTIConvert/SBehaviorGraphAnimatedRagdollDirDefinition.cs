using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGraphAnimatedRagdollDirDefinition : CVariable
	{
		[Ordinal(1)] [RED("dirIndexValue")] 		public CFloat DirIndexValue { get; set;}

		[Ordinal(2)] [RED("relativeAngle")] 		public CFloat RelativeAngle { get; set;}

		[Ordinal(3)] [RED("applyAngleToMovement")] 		public CFloat ApplyAngleToMovement { get; set;}

		[Ordinal(4)] [RED("replacements", 2,0)] 		public CArray<SBehaviorGraphAnimatedRagdollDirReplacement> Replacements { get; set;}

		public SBehaviorGraphAnimatedRagdollDirDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}