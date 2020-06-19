using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPositioningFilter : CVariable
	{
		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("zDiff")] 		public CFloat ZDiff { get; set;}

		[RED("angleLimit")] 		public CFloat AngleLimit { get; set;}

		[RED("personalSpace")] 		public CFloat PersonalSpace { get; set;}

		[RED("awayFromCamera")] 		public CBool AwayFromCamera { get; set;}

		[RED("onlyReachable")] 		public CBool OnlyReachable { get; set;}

		[RED("noRoughTerrain")] 		public CBool NoRoughTerrain { get; set;}

		[RED("noInteriors")] 		public CBool NoInteriors { get; set;}

		[RED("limitToBaseArea")] 		public CBool LimitToBaseArea { get; set;}

		public SPositioningFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPositioningFilter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}