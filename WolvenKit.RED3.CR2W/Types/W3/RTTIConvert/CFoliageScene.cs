using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFoliageScene : CObject
	{
		[Ordinal(1)] [RED("worldDimensions")] 		public Vector2 WorldDimensions { get; set;}

		[Ordinal(2)] [RED("cellDimensions")] 		public Vector2 CellDimensions { get; set;}

		[Ordinal(3)] [RED("visibilityDepth")] 		public CInt32 VisibilityDepth { get; set;}

		[Ordinal(4)] [RED("editorVisibilityDepth")] 		public CInt32 EditorVisibilityDepth { get; set;}

		[Ordinal(5)] [RED("grassMask")] 		public CHandle<CGenericGrassMask> GrassMask { get; set;}

		[Ordinal(6)] [RED("grassOccurrenceMap")] 		public CPtr<CGrassOccurrenceMap> GrassOccurrenceMap { get; set;}

		[Ordinal(7)] [RED("lodSetting")] 		public SFoliageLODSetting LodSetting { get; set;}

		public CFoliageScene(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFoliageScene(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}