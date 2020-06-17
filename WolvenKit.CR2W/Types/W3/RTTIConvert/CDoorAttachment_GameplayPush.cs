using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDoorAttachment_GameplayPush : IDoorAttachment
	{
		[RED("autoCloseForce")] 		public CFloat AutoCloseForce { get; set;}

		[RED("openingSpeed")] 		public CFloat OpeningSpeed { get; set;}

		[RED("invertedPivot")] 		public CBool InvertedPivot { get; set;}

		public CDoorAttachment_GameplayPush(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CDoorAttachment_GameplayPush(cr2w);

	}
}