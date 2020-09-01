using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CActionAreaComponent : CTriggerAreaComponent
	{
		[Ordinal(0)] [RED("walkToSideDistance")] 		public CFloat WalkToSideDistance { get; set;}

		[Ordinal(0)] [RED("walkToBackDistance")] 		public CFloat WalkToBackDistance { get; set;}

		[Ordinal(0)] [RED("walkToFrontDistance")] 		public CFloat WalkToFrontDistance { get; set;}

		[Ordinal(0)] [RED("allowedGroups")] 		public CEnum<EAllowedActorGroups> AllowedGroups { get; set;}

		[Ordinal(0)] [RED("animShiftStart", 2,0)] 		public CArray<Vector> AnimShiftStart { get; set;}

		[Ordinal(0)] [RED("animShiftLoop", 2,0)] 		public CArray<Vector> AnimShiftLoop { get; set;}

		[Ordinal(0)] [RED("animShiftStop", 2,0)] 		public CArray<Vector> AnimShiftStop { get; set;}

		[Ordinal(0)] [RED("totalTransformation")] 		public Vector TotalTransformation { get; set;}

		[Ordinal(0)] [RED("fullTransformation")] 		public CMatrix FullTransformation { get; set;}

		[Ordinal(0)] [RED("animations", 2,0)] 		public CArray<CPtr<CAnimDef>> Animations { get; set;}

		public CActionAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CActionAreaComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}