using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintStirrups : CBehaviorGraphPoseConstraintNode
	{
		[Ordinal(1)] [RED("common")] 		public SBehaviorConstraintStirrupsCommmonData Common { get; set;}

		[Ordinal(2)] [RED("left")] 		public SBehaviorConstraintStirrupData Left { get; set;}

		[Ordinal(3)] [RED("right")] 		public SBehaviorConstraintStirrupData Right { get; set;}

		public CBehaviorConstraintStirrups(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintStirrups(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}