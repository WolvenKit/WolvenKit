using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStoryBoardInteractiveCamera : CStoryBoardShotCamera
	{
		[Ordinal(1)] [RED("isInteractiveMode")] 		public CBool IsInteractiveMode { get; set;}

		[Ordinal(2)] [RED("stepMoveSize")] 		public CFloat StepMoveSize { get; set;}

		[Ordinal(3)] [RED("stepRotSize")] 		public CFloat StepRotSize { get; set;}

		[Ordinal(4)] [RED("defaultDofCenterRadius")] 		public CFloat DefaultDofCenterRadius { get; set;}

		public CStoryBoardInteractiveCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStoryBoardInteractiveCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}