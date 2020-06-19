using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CControlRigSettings : CObject
	{
		[RED("fkBonesNames_l1", 2,0)] 		public CArray<CName> FkBonesNames_l1 { get; set;}

		[RED("fkBones_l1", 2,0)] 		public CArray<CInt32> FkBones_l1 { get; set;}

		[RED("ikBonesNames", 2,0)] 		public CArray<CName> IkBonesNames { get; set;}

		[RED("ikBones", 2,0)] 		public CArray<CInt32> IkBones { get; set;}

		public CControlRigSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CControlRigSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}