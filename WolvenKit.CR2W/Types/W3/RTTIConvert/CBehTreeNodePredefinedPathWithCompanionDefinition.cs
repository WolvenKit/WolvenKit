using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodePredefinedPathWithCompanionDefinition : CBehTreeNodePredefinedPathDefinition
	{
		[RED("companionTag")] 		public CBehTreeValCName CompanionTag { get; set;}

		[RED("maxDistance")] 		public CBehTreeValFloat MaxDistance { get; set;}

		[RED("minDistance")] 		public CBehTreeValFloat MinDistance { get; set;}

		[RED("progressWhenCompanionIsAhead")] 		public CBehTreeValBool ProgressWhenCompanionIsAhead { get; set;}

		[RED("progressOnlyWhenCompanionIsAhead")] 		public CBehTreeValBool ProgressOnlyWhenCompanionIsAhead { get; set;}

		[RED("matchCompanionSpeed")] 		public CBehTreeValBool MatchCompanionSpeed { get; set;}

		[RED("companionOffset")] 		public CBehTreeValFloat CompanionOffset { get; set;}

		[RED("keepMovingWhenMaxDistanceReached")] 		public CBehTreeValBool KeepMovingWhenMaxDistanceReached { get; set;}

		[RED("moveTypeAfterMaxDistanceReached")] 		public CBehTreeValEMoveType MoveTypeAfterMaxDistanceReached { get; set;}

		public CBehTreeNodePredefinedPathWithCompanionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodePredefinedPathWithCompanionDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}