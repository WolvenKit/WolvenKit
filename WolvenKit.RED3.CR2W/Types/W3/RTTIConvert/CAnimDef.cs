using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDef : CObject
	{
		[Ordinal(1)] [RED("animName")] 		public CName AnimName { get; set;}

		[Ordinal(2)] [RED("parent")] 		public CPtr<CAnimDef> Parent { get; set;}

		[Ordinal(3)] [RED("shifts", 2,0)] 		public CArray<SAnimShift> Shifts { get; set;}

		[Ordinal(4)] [RED("totalTransform")] 		public CMatrix TotalTransform { get; set;}

		[Ordinal(5)] [RED("duration")] 		public CFloat Duration { get; set;}

		public CAnimDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}