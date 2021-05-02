using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskGuardChange : IBehTreeTask
	{
		[Ordinal(1)] [RED("raiseGuardChance")] 		public CInt32 RaiseGuardChance { get; set;}

		[Ordinal(2)] [RED("lowerGuardChance")] 		public CInt32 LowerGuardChance { get; set;}

		[Ordinal(3)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(4)] [RED("onDectivate")] 		public CBool OnDectivate { get; set;}

		[Ordinal(5)] [RED("onMain")] 		public CBool OnMain { get; set;}

		[Ordinal(6)] [RED("raiseCheck")] 		public CBool RaiseCheck { get; set;}

		[Ordinal(7)] [RED("lowerCheck")] 		public CBool LowerCheck { get; set;}

		[Ordinal(8)] [RED("frequency")] 		public CFloat Frequency { get; set;}

		[Ordinal(9)] [RED("lastChange")] 		public CFloat LastChange { get; set;}

		public CBTTaskGuardChange(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskGuardChange(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}