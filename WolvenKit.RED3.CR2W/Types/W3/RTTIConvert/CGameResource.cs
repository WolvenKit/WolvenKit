using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameResource : CResource
	{
		[Ordinal(1)] [RED("worlds", 2,0)] 		public CArray<SWorldDescription> Worlds { get; set;}

		[Ordinal(2)] [RED("defaultPlayerTemplate")] 		public CSoft<CEntityTemplate> DefaultPlayerTemplate { get; set;}

		[Ordinal(3)] [RED("defaultCameraTemplate")] 		public CSoft<CEntityTemplate> DefaultCameraTemplate { get; set;}

		[Ordinal(4)] [RED("startingPoint")] 		public EngineTransform StartingPoint { get; set;}

		[Ordinal(5)] [RED("newGameLoadingVideo")] 		public CString NewGameLoadingVideo { get; set;}

		[Ordinal(6)] [RED("playGoChunksToActivate", 2,0)] 		public CArray<CName> PlayGoChunksToActivate { get; set;}

		public CGameResource(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}