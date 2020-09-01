using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMovieData : CVariable
	{
		[Ordinal(1)] [RED("movieName")] 		public CString MovieName { get; set;}

		[Ordinal(2)] [RED("isSkipable")] 		public CBool IsSkipable { get; set;}

		[Ordinal(3)] [RED("showLogo")] 		public CBool ShowLogo { get; set;}

		public SMovieData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMovieData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}