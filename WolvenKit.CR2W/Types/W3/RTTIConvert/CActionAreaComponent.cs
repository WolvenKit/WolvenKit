using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CActionAreaComponent : CTriggerAreaComponent
	{
		[RED("walkToSideDistance")] 		public CFloat WalkToSideDistance { get; set;}

		[RED("walkToBackDistance")] 		public CFloat WalkToBackDistance { get; set;}

		[RED("walkToFrontDistance")] 		public CFloat WalkToFrontDistance { get; set;}

		[RED("allowedGroups")] 		public EAllowedActorGroups AllowedGroups { get; set;}

		[RED("animShiftStart", 2,0)] 		public CArray<Vector> AnimShiftStart { get; set;}

		[RED("animShiftLoop", 2,0)] 		public CArray<Vector> AnimShiftLoop { get; set;}

		[RED("animShiftStop", 2,0)] 		public CArray<Vector> AnimShiftStop { get; set;}

		[RED("totalTransformation")] 		public Vector TotalTransformation { get; set;}

		[RED("fullTransformation")] 		public CMatrix FullTransformation { get; set;}

		[RED("animations", 2,0)] 		public CArray<CPtr<CAnimDef>> Animations { get; set;}

		public CActionAreaComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CActionAreaComponent(cr2w);

	}
}