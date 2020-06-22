using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STimeScaleSource : CVariable
	{
		[RED("timeScale")] 		public CFloat TimeScale { get; set;}

		[RED("name")] 		public CName Name { get; set;}

		[RED("affectCamera")] 		public CBool AffectCamera { get; set;}

		[RED("dontSave")] 		public CBool DontSave { get; set;}

		[RED("priorityIndex")] 		public CUInt32 PriorityIndex { get; set;}

		public STimeScaleSource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STimeScaleSource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}