using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodePredefinedPathWithCompanionDefinition : CBehTreeNodePredefinedPathDefinition
	{
		[Ordinal(1)] [RED("companionTag")] 		public CBehTreeValCName CompanionTag { get; set;}

		[Ordinal(2)] [RED("maxDistance")] 		public CBehTreeValFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("minDistance")] 		public CBehTreeValFloat MinDistance { get; set;}

		[Ordinal(4)] [RED("progressWhenCompanionIsAhead")] 		public CBehTreeValBool ProgressWhenCompanionIsAhead { get; set;}

		[Ordinal(5)] [RED("progressOnlyWhenCompanionIsAhead")] 		public CBehTreeValBool ProgressOnlyWhenCompanionIsAhead { get; set;}

		[Ordinal(6)] [RED("matchCompanionSpeed")] 		public CBehTreeValBool MatchCompanionSpeed { get; set;}

		[Ordinal(7)] [RED("companionOffset")] 		public CBehTreeValFloat CompanionOffset { get; set;}

		[Ordinal(8)] [RED("keepMovingWhenMaxDistanceReached")] 		public CBehTreeValBool KeepMovingWhenMaxDistanceReached { get; set;}

		[Ordinal(9)] [RED("moveTypeAfterMaxDistanceReached")] 		public CBehTreeValEMoveType MoveTypeAfterMaxDistanceReached { get; set;}

		public CBehTreeNodePredefinedPathWithCompanionDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodePredefinedPathWithCompanionDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}