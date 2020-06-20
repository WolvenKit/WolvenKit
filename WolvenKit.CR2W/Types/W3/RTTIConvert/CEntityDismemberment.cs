using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEntityDismemberment : CEntityTemplateParam
	{
		[RED("wounds", 2,0)] 		public CArray<CPtr<CDismembermentWound>> Wounds { get; set;}

		[RED("disabledWounds", 2,0)] 		public CArray<SDismembermentWoundFilter> DisabledWounds { get; set;}

		public CEntityDismemberment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEntityDismemberment(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}