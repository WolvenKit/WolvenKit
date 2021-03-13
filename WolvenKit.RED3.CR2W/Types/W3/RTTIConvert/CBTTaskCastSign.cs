using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCastSign : CBTTaskAttack
	{
		[Ordinal(1)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(2)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(3)] [RED("signEntity")] 		public CHandle<W3SignEntity> SignEntity { get; set;}

		[Ordinal(4)] [RED("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[Ordinal(5)] [RED("signType")] 		public CEnum<ESignType> SignType { get; set;}

		[Ordinal(6)] [RED("attackRangeName")] 		public CName AttackRangeName { get; set;}

		[Ordinal(7)] [RED("signOwner")] 		public CHandle<W3SignOwnerBTTaskCastSign> SignOwner { get; set;}

		public CBTTaskCastSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCastSign(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}