using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CChangeFacingDirectionTransitionCondition : IBehaviorStateTransitionCondition
	{
		[Ordinal(1)] [RED("side")] 		public CEnum<EChangeFacingDirectionSide> Side { get; set;}

		[Ordinal(2)] [RED("angleDiffMin")] 		public CFloat AngleDiffMin { get; set;}

		[Ordinal(3)] [RED("angleDiffMax")] 		public CFloat AngleDiffMax { get; set;}

		[Ordinal(4)] [RED("startCheckingAfterTime")] 		public CFloat StartCheckingAfterTime { get; set;}

		[Ordinal(5)] [RED("requestedFacingDirectionWSVariableName")] 		public CName RequestedFacingDirectionWSVariableName { get; set;}

		[Ordinal(6)] [RED("dontChange")] 		public CBool DontChange { get; set;}

		public CChangeFacingDirectionTransitionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CChangeFacingDirectionTransitionCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}