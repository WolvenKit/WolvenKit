using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Potion_Cat : CBaseGameplayEffect
	{
		[Ordinal(0)] [RED("("highlightObjectsRange")] 		public CFloat HighlightObjectsRange { get; set;}

		[Ordinal(0)] [RED("("highlightEnemiesRange")] 		public CFloat HighlightEnemiesRange { get; set;}

		[Ordinal(0)] [RED("("witcher")] 		public CHandle<W3PlayerWitcher> Witcher { get; set;}

		[Ordinal(0)] [RED("("isScreenFxActive")] 		public CBool IsScreenFxActive { get; set;}

		[Ordinal(0)] [RED("("timeSinceLastHighlight")] 		public CFloat TimeSinceLastHighlight { get; set;}

		[Ordinal(0)] [RED("("timeSinceLastEnemyHighlight")] 		public CFloat TimeSinceLastEnemyHighlight { get; set;}

		[Ordinal(0)] [RED("("HIGHLIGHT_REFRESH_DT")] 		public CFloat HIGHLIGHT_REFRESH_DT { get; set;}

		[Ordinal(0)] [RED("("ENEMY_HIGHLIGHT_DT")] 		public CFloat ENEMY_HIGHLIGHT_DT { get; set;}

		public W3Potion_Cat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Potion_Cat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}