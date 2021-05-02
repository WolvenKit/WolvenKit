using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_SetAppearanceOnEntity : W3SwitchEvent
	{
		[Ordinal(1)] [RED("entityHandle")] 		public EntityHandle EntityHandle { get; set;}

		[Ordinal(2)] [RED("appearanceName")] 		public CString AppearanceName { get; set;}

		[Ordinal(3)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		public W3SE_SetAppearanceOnEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SE_SetAppearanceOnEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}