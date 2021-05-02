using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIRiderFollowActionParams : IRiderActionParameters
	{
		[Ordinal(1)] [RED("targetTag")] 		public CName TargetTag { get; set;}

		[Ordinal(2)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(3)] [RED("keepDistance")] 		public CBool KeepDistance { get; set;}

		[Ordinal(4)] [RED("followDistance")] 		public CFloat FollowDistance { get; set;}

		[Ordinal(5)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(6)] [RED("followTargetSelection")] 		public CBool FollowTargetSelection { get; set;}

		[Ordinal(7)] [RED("matchRiderMountStatus")] 		public CBool MatchRiderMountStatus { get; set;}

		public CAIRiderFollowActionParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIRiderFollowActionParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}