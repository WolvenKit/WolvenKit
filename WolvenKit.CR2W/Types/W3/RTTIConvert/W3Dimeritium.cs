using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Dimeritium : W3Petard
	{
		[Ordinal(1)] [RED("affectedFX")] 		public CName AffectedFX { get; set;}

		[Ordinal(2)] [RED("affectedFXCluster")] 		public CName AffectedFXCluster { get; set;}

		[Ordinal(3)] [RED("disableTimerCalled")] 		public CBool DisableTimerCalled { get; set;}

		[Ordinal(4)] [RED("DISABLED_FX_CHECK_DELAY")] 		public CFloat DISABLED_FX_CHECK_DELAY { get; set;}

		[Ordinal(5)] [RED("disabledFxDT")] 		public CFloat DisabledFxDT { get; set;}

		public W3Dimeritium(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Dimeritium(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}