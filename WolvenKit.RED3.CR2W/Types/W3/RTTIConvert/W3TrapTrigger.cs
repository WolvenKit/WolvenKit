using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapTrigger : W3GameplayTrigger
	{
		[Ordinal(1)] [RED("m_TrapsToActivateTag")] 		public CName M_TrapsToActivateTag { get; set;}

		[Ordinal(2)] [RED("m_MaxActivation")] 		public CInt32 M_MaxActivation { get; set;}

		[Ordinal(3)] [RED("m_DeactivateOnExit")] 		public CBool M_DeactivateOnExit { get; set;}

		[Ordinal(4)] [RED("m_Enabled")] 		public CBool M_Enabled { get; set;}

		[Ordinal(5)] [RED("m_playerOnly")] 		public CBool M_playerOnly { get; set;}

		[Ordinal(6)] [RED("m_excludedEntitiesTags", 2,0)] 		public CArray<CName> M_excludedEntitiesTags { get; set;}

		[Ordinal(7)] [RED("m_trapsToActivateByTag", 2,0)] 		public CArray<CHandle<CEntity>> M_trapsToActivateByTag { get; set;}

		[Ordinal(8)] [RED("m_Activations")] 		public CInt32 M_Activations { get; set;}

		[Ordinal(9)] [RED("m_EntitiesInside")] 		public CInt32 M_EntitiesInside { get; set;}

		public W3TrapTrigger(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TrapTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}