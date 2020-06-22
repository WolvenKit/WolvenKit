using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMagicBomb : CBTTaskAttack
	{
		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("targetPos")] 		public Vector TargetPos { get; set;}

		[RED("targetRot")] 		public EulerAngles TargetRot { get; set;}

		[RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		public CBTTaskMagicBomb(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMagicBomb(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}