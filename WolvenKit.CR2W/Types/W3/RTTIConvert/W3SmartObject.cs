using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SmartObject : CR4MapPinEntity
	{
		[RED("startAnim")] 		public CName StartAnim { get; set;}

		[RED("loopAnims", 2,0)] 		public CArray<CName> LoopAnims { get; set;}

		[RED("stopAnim")] 		public CName StopAnim { get; set;}

		[RED("canBeInterruptedByInput")] 		public CBool CanBeInterruptedByInput { get; set;}

		public W3SmartObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SmartObject(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}