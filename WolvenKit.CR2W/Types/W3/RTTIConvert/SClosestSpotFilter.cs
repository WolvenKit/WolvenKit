using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SClosestSpotFilter : CVariable
	{
		[Ordinal(0)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("zDiff")] 		public CFloat ZDiff { get; set;}

		[Ordinal(0)] [RED("awayFromCamera")] 		public CBool AwayFromCamera { get; set;}

		[Ordinal(0)] [RED("("onlyReachable")] 		public CBool OnlyReachable { get; set;}

		[Ordinal(0)] [RED("("noRoughTerrain")] 		public CBool NoRoughTerrain { get; set;}

		[Ordinal(0)] [RED("("noInteriors")] 		public CBool NoInteriors { get; set;}

		[Ordinal(0)] [RED("("limitToBaseArea")] 		public CBool LimitToBaseArea { get; set;}

		[Ordinal(0)] [RED("("limitedPrecision")] 		public CBool LimitedPrecision { get; set;}

		public SClosestSpotFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SClosestSpotFilter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}