using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SignEntity : CGameplayEntity
	{
		[Ordinal(0)] [RED("("owner")] 		public CHandle<W3SignOwner> Owner { get; set;}

		[Ordinal(0)] [RED("("attachedTo")] 		public CHandle<CEntity> AttachedTo { get; set;}

		[Ordinal(0)] [RED("("boneIndex")] 		public CInt32 BoneIndex { get; set;}

		[Ordinal(0)] [RED("("fireMode")] 		public CInt32 FireMode { get; set;}

		[Ordinal(0)] [RED("("skillEnum")] 		public CEnum<ESkill> SkillEnum { get; set;}

		[Ordinal(0)] [RED("("signType")] 		public CEnum<ESignType> SignType { get; set;}

		[Ordinal(0)] [RED("("actionBuffs", 2,0)] 		public CArray<SEffectInfo> ActionBuffs { get; set;}

		[Ordinal(0)] [RED("("friendlyCastEffect")] 		public CName FriendlyCastEffect { get; set;}

		[Ordinal(0)] [RED("("cachedCost")] 		public CFloat CachedCost { get; set;}

		[Ordinal(0)] [RED("("usedFocus")] 		public CBool UsedFocus { get; set;}

		public W3SignEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SignEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}