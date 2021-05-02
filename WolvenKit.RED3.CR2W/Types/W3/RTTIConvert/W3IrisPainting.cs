using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3IrisPainting : CGameplayEntity
	{
		[Ordinal(1)] [RED("portalHP")] 		public CInt32 PortalHP { get; set;}

		[Ordinal(2)] [RED("m_PortalCurrentHP")] 		public CInt32 M_PortalCurrentHP { get; set;}

		[Ordinal(3)] [RED("m_IsOpen")] 		public CBool M_IsOpen { get; set;}

		[Ordinal(4)] [RED("m_IsReady")] 		public CBool M_IsReady { get; set;}

		[Ordinal(5)] [RED("m_ChargingTotalDuration")] 		public CFloat M_ChargingTotalDuration { get; set;}

		[Ordinal(6)] [RED("m_ChargingStepDuration")] 		public CFloat M_ChargingStepDuration { get; set;}

		[Ordinal(7)] [RED("m_LocktagsOn")] 		public CBool M_LocktagsOn { get; set;}

		public W3IrisPainting(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}