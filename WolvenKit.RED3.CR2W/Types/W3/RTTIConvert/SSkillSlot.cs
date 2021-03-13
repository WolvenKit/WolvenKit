using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSkillSlot : CVariable
	{
		[Ordinal(1)] [RED("id")] 		public CInt32 Id { get; set;}

		[Ordinal(2)] [RED("unlockedOnLevel")] 		public CInt32 UnlockedOnLevel { get; set;}

		[Ordinal(3)] [RED("socketedSkill")] 		public CEnum<ESkill> SocketedSkill { get; set;}

		[Ordinal(4)] [RED("unlocked")] 		public CBool Unlocked { get; set;}

		[Ordinal(5)] [RED("groupID")] 		public CInt32 GroupID { get; set;}

		public SSkillSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSkillSlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}