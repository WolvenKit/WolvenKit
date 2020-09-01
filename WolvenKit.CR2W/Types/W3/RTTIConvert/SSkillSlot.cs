using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSkillSlot : CVariable
	{
		[Ordinal(1)] [RED("("id")] 		public CInt32 Id { get; set;}

		[Ordinal(2)] [RED("("unlockedOnLevel")] 		public CInt32 UnlockedOnLevel { get; set;}

		[Ordinal(3)] [RED("("socketedSkill")] 		public CEnum<ESkill> SocketedSkill { get; set;}

		[Ordinal(4)] [RED("("unlocked")] 		public CBool Unlocked { get; set;}

		[Ordinal(5)] [RED("("groupID")] 		public CInt32 GroupID { get; set;}

		public SSkillSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSkillSlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}