using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CComponent : CNode
	{
		[Ordinal(1)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(2)] [RED("isStreamed")] 		public CBool IsStreamed { get; set;}

		[Ordinal(3)] [RED("graphPositionX")] 		public CInt16 GraphPositionX { get; set;}

		[Ordinal(4)] [RED("graphPositionY")] 		public CInt16 GraphPositionY { get; set;}

		public CComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}