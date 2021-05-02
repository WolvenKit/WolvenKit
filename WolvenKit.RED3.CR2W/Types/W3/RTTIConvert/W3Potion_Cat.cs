using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Potion_Cat : CBaseGameplayEffect
	{
		[Ordinal(1)] [RED("highlightObjectsRange")] 		public CFloat HighlightObjectsRange { get; set;}

		[Ordinal(2)] [RED("highlightEnemiesRange")] 		public CFloat HighlightEnemiesRange { get; set;}

		[Ordinal(3)] [RED("witcher")] 		public CHandle<W3PlayerWitcher> Witcher { get; set;}

		[Ordinal(4)] [RED("isScreenFxActive")] 		public CBool IsScreenFxActive { get; set;}

		[Ordinal(5)] [RED("timeSinceLastHighlight")] 		public CFloat TimeSinceLastHighlight { get; set;}

		[Ordinal(6)] [RED("timeSinceLastEnemyHighlight")] 		public CFloat TimeSinceLastEnemyHighlight { get; set;}

		[Ordinal(7)] [RED("HIGHLIGHT_REFRESH_DT")] 		public CFloat HIGHLIGHT_REFRESH_DT { get; set;}

		[Ordinal(8)] [RED("ENEMY_HIGHLIGHT_DT")] 		public CFloat ENEMY_HIGHLIGHT_DT { get; set;}

		public W3Potion_Cat(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Potion_Cat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}