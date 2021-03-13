using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SReward : CVariable
	{
		[Ordinal(1)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(2)] [RED("experience")] 		public CInt32 Experience { get; set;}

		[Ordinal(3)] [RED("level")] 		public CInt32 Level { get; set;}

		[Ordinal(4)] [RED("gold")] 		public CInt32 Gold { get; set;}

		[Ordinal(5)] [RED("items", 2,0)] 		public CArray<SItemReward> Items { get; set;}

		[Ordinal(6)] [RED("achievement")] 		public CInt32 Achievement { get; set;}

		[Ordinal(7)] [RED("script")] 		public CName Script { get; set;}

		[Ordinal(8)] [RED("comment")] 		public CString Comment { get; set;}

		public SReward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SReward(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}