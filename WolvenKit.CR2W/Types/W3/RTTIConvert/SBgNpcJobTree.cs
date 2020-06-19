using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBgNpcJobTree : CVariable
	{
		[RED("jobTree")] 		public CSoft<CJobTree> JobTree { get; set;}

		[RED("category")] 		public CName Category { get; set;}

		[RED("fireTime")] 		public GameTime FireTime { get; set;}

		public SBgNpcJobTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBgNpcJobTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}