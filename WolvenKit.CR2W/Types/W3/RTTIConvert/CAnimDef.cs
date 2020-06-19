using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDef : CObject
	{
		[RED("animName")] 		public CName AnimName { get; set;}

		[RED("parent")] 		public CPtr<CAnimDef> Parent { get; set;}

		[RED("shifts", 2,0)] 		public CArray<SAnimShift> Shifts { get; set;}

		[RED("totalTransform")] 		public CMatrix TotalTransform { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		public CAnimDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}