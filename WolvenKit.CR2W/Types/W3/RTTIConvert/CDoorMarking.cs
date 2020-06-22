using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDoorMarking : CScriptedComponent
	{
		[RED("changeCamera")] 		public CBool ChangeCamera { get; set;}

		[RED("calculated")] 		public CBool Calculated { get; set;}

		[RED("pointA")] 		public Vector PointA { get; set;}

		[RED("pointB")] 		public Vector PointB { get; set;}

		[RED("middlePoint")] 		public Vector MiddlePoint { get; set;}

		[RED("normal")] 		public Vector Normal { get; set;}

		[RED("checkState")] 		public CEnum<EDoorMarkingState> CheckState { get; set;}

		[RED("initialized")] 		public CBool Initialized { get; set;}

		public CDoorMarking(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDoorMarking(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}