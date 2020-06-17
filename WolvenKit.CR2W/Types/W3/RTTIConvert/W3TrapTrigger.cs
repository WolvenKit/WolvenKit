using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapTrigger : W3GameplayTrigger
	{
		[RED("m_TrapsToActivateTag")] 		public CName M_TrapsToActivateTag { get; set;}

		[RED("m_MaxActivation")] 		public CInt32 M_MaxActivation { get; set;}

		[RED("m_DeactivateOnExit")] 		public CBool M_DeactivateOnExit { get; set;}

		[RED("m_Enabled")] 		public CBool M_Enabled { get; set;}

		[RED("m_playerOnly")] 		public CBool M_playerOnly { get; set;}

		[RED("m_excludedEntitiesTags", 2,0)] 		public CArray<CName> M_excludedEntitiesTags { get; set;}

		public W3TrapTrigger(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3TrapTrigger(cr2w);

	}
}