using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMajorPlaceOfPowerEntity : CInteractiveEntity
	{
		[RED("buffType")] 		public CEnum<EShrineBuffs> BuffType { get; set;}

		[RED("buffUniqueName")] 		public CString BuffUniqueName { get; set;}

		[RED("fxOnIdle")] 		public CName FxOnIdle { get; set;}

		[RED("fxOnChannel")] 		public CName FxOnChannel { get; set;}

		[RED("fxOnSuccess")] 		public CName FxOnSuccess { get; set;}

		public CMajorPlaceOfPowerEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMajorPlaceOfPowerEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}