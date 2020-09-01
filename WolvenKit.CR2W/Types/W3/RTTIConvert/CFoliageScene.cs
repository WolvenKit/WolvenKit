using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFoliageScene : CObject
	{
		[Ordinal(0)] [RED("("worldDimensions")] 		public Vector2 WorldDimensions { get; set;}

		[Ordinal(0)] [RED("("cellDimensions")] 		public Vector2 CellDimensions { get; set;}

		[Ordinal(0)] [RED("("visibilityDepth")] 		public CInt32 VisibilityDepth { get; set;}

		[Ordinal(0)] [RED("("editorVisibilityDepth")] 		public CInt32 EditorVisibilityDepth { get; set;}

		[Ordinal(0)] [RED("("grassMask")] 		public CHandle<CGenericGrassMask> GrassMask { get; set;}

		[Ordinal(0)] [RED("("grassOccurrenceMap")] 		public CPtr<CGrassOccurrenceMap> GrassOccurrenceMap { get; set;}

		[Ordinal(0)] [RED("("lodSetting")] 		public SFoliageLODSetting LodSetting { get; set;}

		public CFoliageScene(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFoliageScene(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}