using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BuffDoTParams : W3BuffCustomParams
	{
		[Ordinal(1)] [RED("isEnvironment")] 		public CBool IsEnvironment { get; set;}

		[Ordinal(2)] [RED("isPerk20Active")] 		public CBool IsPerk20Active { get; set;}

		public W3BuffDoTParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}