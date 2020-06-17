using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneVideoSection : CStorySceneSection
	{
		[RED("videoFileName")] 		public CString VideoFileName { get; set;}

		[RED("eventDescription")] 		public CString EventDescription { get; set;}

		[RED("suppressRendering")] 		public CBool SuppressRendering { get; set;}

		[RED("extraVideoFileNames", 2,0)] 		public CArray<CString> ExtraVideoFileNames { get; set;}

		public CStorySceneVideoSection(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneVideoSection(cr2w);

	}
}