using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEntityDismemberment : CEntityTemplateParam
	{
		[Ordinal(1)] [RED("wounds", 2,0)] 		public CArray<CPtr<CDismembermentWound>> Wounds { get; set;}

		[Ordinal(2)] [RED("disabledWounds", 2,0)] 		public CArray<SDismembermentWoundFilter> DisabledWounds { get; set;}

		public CEntityDismemberment(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}