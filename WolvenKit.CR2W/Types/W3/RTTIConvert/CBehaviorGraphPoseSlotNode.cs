using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphPoseSlotNode : CBehaviorGraphBaseNode
	{
		[Ordinal(0)] [RED("("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(0)] [RED("("firstBone")] 		public CString FirstBone { get; set;}

		[Ordinal(0)] [RED("("worldSpace")] 		public CBool WorldSpace { get; set;}

		[Ordinal(0)] [RED("("interpolation")] 		public CEnum<EInterpolationType> Interpolation { get; set;}

		[Ordinal(0)] [RED("("blendFloatTracks")] 		public CBool BlendFloatTracks { get; set;}

		[Ordinal(0)] [RED("("ignoreZeroFloatTracks")] 		public CBool IgnoreZeroFloatTracks { get; set;}

		public CBehaviorGraphPoseSlotNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphPoseSlotNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}