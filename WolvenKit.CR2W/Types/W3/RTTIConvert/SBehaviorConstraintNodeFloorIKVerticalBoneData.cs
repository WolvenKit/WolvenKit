using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorConstraintNodeFloorIKVerticalBoneData : CVariable
	{
		[RED("bone")] 		public CName Bone { get; set;}

		[RED("Min offset")] 		public CFloat Min_offset { get; set;}

		[RED("Max offset")] 		public CFloat Max_offset { get; set;}

		[RED("offsetToDesiredBlendTime")] 		public CFloat OffsetToDesiredBlendTime { get; set;}

		[RED("verticalOffsetBlendTime")] 		public CFloat VerticalOffsetBlendTime { get; set;}

		[RED("stiffness")] 		public CFloat Stiffness { get; set;}

		public SBehaviorConstraintNodeFloorIKVerticalBoneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorConstraintNodeFloorIKVerticalBoneData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}