using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCastSign : CBTTaskAttack
	{
		[Ordinal(0)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(0)] [RED("signEntity")] 		public CHandle<W3SignEntity> SignEntity { get; set;}

		[Ordinal(0)] [RED("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[Ordinal(0)] [RED("signType")] 		public CEnum<ESignType> SignType { get; set;}

		[Ordinal(0)] [RED("attackRangeName")] 		public CName AttackRangeName { get; set;}

		[Ordinal(0)] [RED("signOwner")] 		public CHandle<W3SignOwnerBTTaskCastSign> SignOwner { get; set;}

		public CBTTaskCastSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCastSign(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}