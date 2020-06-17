using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneAddFactEvent : CStorySceneEvent
	{
		[RED("factId")] 		public CString FactId { get; set;}

		[RED("expireTime")] 		public CInt32 ExpireTime { get; set;}

		[RED("factValue")] 		public CInt32 FactValue { get; set;}

		public CStorySceneAddFactEvent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneAddFactEvent(cr2w);

	}
}