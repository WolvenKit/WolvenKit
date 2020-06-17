using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterSpawnParams : CAISubTreeParameters
	{
		[RED("fxName")] 		public CName FxName { get; set;}

		[RED("animEventNameActivator")] 		public CName AnimEventNameActivator { get; set;}

		[RED("playFXOnAnimEvent")] 		public CBool PlayFXOnAnimEvent { get; set;}

		[RED("monitorGroundContact")] 		public CBool MonitorGroundContact { get; set;}

		[RED("dealDamageOnAnimEvent")] 		public CName DealDamageOnAnimEvent { get; set;}

		[RED("becomeVisibleOnAnimEvent")] 		public CName BecomeVisibleOnAnimEvent { get; set;}

		public CAIMonsterSpawnParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIMonsterSpawnParams(cr2w);

	}
}