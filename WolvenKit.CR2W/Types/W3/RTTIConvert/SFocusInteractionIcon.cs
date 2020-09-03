using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFocusInteractionIcon : CVariable
	{
		[Ordinal(1)] [RED("m_id")] 		public CInt32 M_id { get; set;}

		[Ordinal(2)] [RED("m_actionName")] 		public CName M_actionName { get; set;}

		[Ordinal(3)] [RED("m_entity")] 		public CHandle<CEntity> M_entity { get; set;}

		[Ordinal(4)] [RED("m_screenPos")] 		public Vector M_screenPos { get; set;}

		[Ordinal(5)] [RED("m_distanceSquared")] 		public CFloat M_distanceSquared { get; set;}

		[Ordinal(6)] [RED("m_valid")] 		public CBool M_valid { get; set;}

		[Ordinal(7)] [RED("m_canBeSeen")] 		public CBool M_canBeSeen { get; set;}

		[Ordinal(8)] [RED("m_isSeen")] 		public CBool M_isSeen { get; set;}

		public SFocusInteractionIcon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFocusInteractionIcon(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}