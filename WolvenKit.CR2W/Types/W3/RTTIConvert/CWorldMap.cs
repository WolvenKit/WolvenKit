using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWorldMap : CResource
	{
		[RED("guid")] 		public CGUID Guid { get; set;}

		[RED("displayTitle")] 		public LocalizedString DisplayTitle { get; set;}

		[RED("imageInfo")] 		public SWorldMapImageInfo ImageInfo { get; set;}

		[RED("staticMapPins", 2,0)] 		public CArray<SStaticMapPin> StaticMapPins { get; set;}

		public CWorldMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWorldMap(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}