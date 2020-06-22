using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SReward : CVariable
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("experience")] 		public CInt32 Experience { get; set;}

		[RED("level")] 		public CInt32 Level { get; set;}

		[RED("gold")] 		public CInt32 Gold { get; set;}

		[RED("items", 2,0)] 		public CArray<SItemReward> Items { get; set;}

		[RED("achievement")] 		public CInt32 Achievement { get; set;}

		[RED("script")] 		public CName Script { get; set;}

		[RED("comment")] 		public CString Comment { get; set;}

		public SReward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SReward(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}