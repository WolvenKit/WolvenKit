using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockOutputColorDeferred : CMaterialRootBlock
	{
		[Ordinal(0)] [RED("isTwoSided")] 		public CBool IsTwoSided { get; set;}

		[Ordinal(0)] [RED("rawOutput")] 		public CBool RawOutput { get; set;}

		[Ordinal(0)] [RED("maskThreshold")] 		public CFloat MaskThreshold { get; set;}

		[Ordinal(0)] [RED("terrain")] 		public CBool Terrain { get; set;}

		public CMaterialBlockOutputColorDeferred(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockOutputColorDeferred(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}