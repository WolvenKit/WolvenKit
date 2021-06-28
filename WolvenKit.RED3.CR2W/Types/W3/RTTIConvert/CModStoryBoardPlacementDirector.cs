using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardPlacementDirector : CObject
	{
		[Ordinal(1)] [RED("assets", 2,0)] 		public CArray<CHandle<CModStoryBoardAsset>> Assets { get; set;}

		[Ordinal(2)] [RED("originPos")] 		public Vector OriginPos { get; set;}

		[Ordinal(3)] [RED("originRot")] 		public EulerAngles OriginRot { get; set;}

		[Ordinal(4)] [RED("originAssetId")] 		public CString OriginAssetId { get; set;}

		public CModStoryBoardPlacementDirector(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}