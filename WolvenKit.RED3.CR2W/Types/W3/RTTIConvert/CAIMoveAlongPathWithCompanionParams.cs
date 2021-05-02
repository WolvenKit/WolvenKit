using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMoveAlongPathWithCompanionParams : CAIMoveAlongPathParams
	{
		[Ordinal(1)] [RED("companionTag")] 		public CName CompanionTag { get; set;}

		[Ordinal(2)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(4)] [RED("companionOffset")] 		public CFloat CompanionOffset { get; set;}

		[Ordinal(5)] [RED("progressWhenCompanionIsAhead")] 		public CBool ProgressWhenCompanionIsAhead { get; set;}

		[Ordinal(6)] [RED("progressOnlyWhenCompanionIsAhead")] 		public CBool ProgressOnlyWhenCompanionIsAhead { get; set;}

		[Ordinal(7)] [RED("matchCompanionSpeed")] 		public CBool MatchCompanionSpeed { get; set;}

		[Ordinal(8)] [RED("allowLeaderToRideOff")] 		public CBool AllowLeaderToRideOff { get; set;}

		[Ordinal(9)] [RED("moveTypeAfterMaxDistance")] 		public CEnum<EMoveType> MoveTypeAfterMaxDistance { get; set;}

		public CAIMoveAlongPathWithCompanionParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMoveAlongPathWithCompanionParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}