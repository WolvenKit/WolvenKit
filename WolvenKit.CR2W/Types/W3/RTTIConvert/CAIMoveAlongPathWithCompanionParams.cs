using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMoveAlongPathWithCompanionParams : CAIMoveAlongPathParams
	{
		[RED("companionTag")] 		public CName CompanionTag { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("companionOffset")] 		public CFloat CompanionOffset { get; set;}

		[RED("progressWhenCompanionIsAhead")] 		public CBool ProgressWhenCompanionIsAhead { get; set;}

		[RED("progressOnlyWhenCompanionIsAhead")] 		public CBool ProgressOnlyWhenCompanionIsAhead { get; set;}

		[RED("matchCompanionSpeed")] 		public CBool MatchCompanionSpeed { get; set;}

		[RED("allowLeaderToRideOff")] 		public CBool AllowLeaderToRideOff { get; set;}

		[RED("moveTypeAfterMaxDistance")] 		public CEnum<EMoveType> MoveTypeAfterMaxDistance { get; set;}

		public CAIMoveAlongPathWithCompanionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMoveAlongPathWithCompanionParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}