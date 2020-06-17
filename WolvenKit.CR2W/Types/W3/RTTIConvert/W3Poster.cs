using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Poster : CGameplayEntity
	{
		[RED("description")] 		public CString Description { get; set;}

		[RED("camera")] 		public CHandle<CEntityTemplate> Camera { get; set;}

		[RED("factOnRead")] 		public CString FactOnRead { get; set;}

		[RED("factOnInteraction")] 		public CString FactOnInteraction { get; set;}

		[RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[RED("blendOutTime")] 		public CFloat BlendOutTime { get; set;}

		[RED("fadeStartDuration")] 		public CFloat FadeStartDuration { get; set;}

		[RED("fadeEndDuration")] 		public CFloat FadeEndDuration { get; set;}

		[RED("focusModeHighlight")] 		public EFocusModeVisibility FocusModeHighlight { get; set;}

		[RED("alignLeft")] 		public CBool AlignLeft { get; set;}

		public W3Poster(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3Poster(cr2w);

	}
}