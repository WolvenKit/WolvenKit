using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageHPRegenEffects : BTTaskIrisTask
	{
		[Ordinal(0)] [RED("ResumeEffect")] 		public CBool ResumeEffect { get; set;}

		[Ordinal(0)] [RED("OnDeactivate")] 		public CBool OnDeactivate { get; set;}

		public BTTaskManageHPRegenEffects(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageHPRegenEffects(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}