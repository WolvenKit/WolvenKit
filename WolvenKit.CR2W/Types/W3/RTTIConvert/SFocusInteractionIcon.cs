using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFocusInteractionIcon : CVariable
	{
		[RED("m_id")] 		public CInt32 M_id { get; set;}

		[RED("m_actionName")] 		public CName M_actionName { get; set;}

		[RED("m_entity")] 		public CHandle<CEntity> M_entity { get; set;}

		[RED("m_screenPos")] 		public Vector M_screenPos { get; set;}

		[RED("m_distanceSquared")] 		public CFloat M_distanceSquared { get; set;}

		[RED("m_valid")] 		public CBool M_valid { get; set;}

		[RED("m_canBeSeen")] 		public CBool M_canBeSeen { get; set;}

		[RED("m_isSeen")] 		public CBool M_isSeen { get; set;}

		public SFocusInteractionIcon(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFocusInteractionIcon(cr2w);

	}
}