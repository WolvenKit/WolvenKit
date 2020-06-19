using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameResource : CResource
	{
		[RED("worlds", 2,0)] 		public CArray<SWorldDescription> Worlds { get; set;}

		[RED("defaultPlayerTemplate")] 		public CSoft<CEntityTemplate> DefaultPlayerTemplate { get; set;}

		[RED("defaultCameraTemplate")] 		public CSoft<CEntityTemplate> DefaultCameraTemplate { get; set;}

		[RED("startingPoint")] 		public EngineTransform StartingPoint { get; set;}

		[RED("newGameLoadingVideo")] 		public CString NewGameLoadingVideo { get; set;}

		[RED("playGoChunksToActivate", 2,0)] 		public CArray<CName> PlayGoChunksToActivate { get; set;}

		public CGameResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}