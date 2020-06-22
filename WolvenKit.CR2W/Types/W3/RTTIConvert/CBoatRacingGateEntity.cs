using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBoatRacingGateEntity : CGameplayEntity
	{
		[RED("nextGate")] 		public EntityHandle NextGate { get; set;}

		[RED("factOnReaching")] 		public CString FactOnReaching { get; set;}

		[RED("nextGateEntity")] 		public CHandle<CBoatRacingGateEntity> NextGateEntity { get; set;}

		[RED("isActive")] 		public CBool IsActive { get; set;}

		[RED("isReached")] 		public CBool IsReached { get; set;}

		public CBoatRacingGateEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBoatRacingGateEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}