using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Poster : CGameplayEntity
	{
		[Ordinal(0)] [RED("("descriptionGenerated")] 		public CBool DescriptionGenerated { get; set;}

		[Ordinal(0)] [RED("("description")] 		public CString Description { get; set;}

		[Ordinal(0)] [RED("("camera")] 		public CHandle<CEntityTemplate> Camera { get; set;}

		[Ordinal(0)] [RED("("factOnRead")] 		public CString FactOnRead { get; set;}

		[Ordinal(0)] [RED("("factOnInteraction")] 		public CString FactOnInteraction { get; set;}

		[Ordinal(0)] [RED("("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[Ordinal(0)] [RED("("blendOutTime")] 		public CFloat BlendOutTime { get; set;}

		[Ordinal(0)] [RED("("fadeStartDuration")] 		public CFloat FadeStartDuration { get; set;}

		[Ordinal(0)] [RED("("fadeEndDuration")] 		public CFloat FadeEndDuration { get; set;}

		[Ordinal(0)] [RED("("focusModeHighlight")] 		public CEnum<EFocusModeVisibility> FocusModeHighlight { get; set;}

		[Ordinal(0)] [RED("("alignLeft")] 		public CBool AlignLeft { get; set;}

		[Ordinal(0)] [RED("("restoreUsableItemAtEnd")] 		public CBool RestoreUsableItemAtEnd { get; set;}

		[Ordinal(0)] [RED("("spawnedCamera")] 		public CHandle<CStaticCamera> SpawnedCamera { get; set;}

		public W3Poster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Poster(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}