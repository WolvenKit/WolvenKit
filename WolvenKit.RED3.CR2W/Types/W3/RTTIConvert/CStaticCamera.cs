using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStaticCamera : CCamera
	{
		[Ordinal(1)] [RED("solver")] 		public CEnum<ECameraSolver> Solver { get; set;}

		[Ordinal(2)] [RED("activationDuration")] 		public CFloat ActivationDuration { get; set;}

		[Ordinal(3)] [RED("deactivationDuration")] 		public CFloat DeactivationDuration { get; set;}

		[Ordinal(4)] [RED("timeout")] 		public CFloat Timeout { get; set;}

		[Ordinal(5)] [RED("zoom")] 		public CFloat Zoom { get; set;}

		[Ordinal(6)] [RED("fov")] 		public CFloat Fov { get; set;}

		[Ordinal(7)] [RED("animState")] 		public CInt32 AnimState { get; set;}

		[Ordinal(8)] [RED("guiEffect")] 		public CInt32 GuiEffect { get; set;}

		[Ordinal(9)] [RED("blockPlayer")] 		public CBool BlockPlayer { get; set;}

		[Ordinal(10)] [RED("resetPlayerCamera")] 		public CBool ResetPlayerCamera { get; set;}

		[Ordinal(11)] [RED("fadeStartDuration")] 		public CFloat FadeStartDuration { get; set;}

		[Ordinal(12)] [RED("fadeStartColor")] 		public CColor FadeStartColor { get; set;}

		[Ordinal(13)] [RED("isFadeStartFadeIn")] 		public CBool IsFadeStartFadeIn { get; set;}

		[Ordinal(14)] [RED("fadeEndDuration")] 		public CFloat FadeEndDuration { get; set;}

		[Ordinal(15)] [RED("fadeEndColor")] 		public CColor FadeEndColor { get; set;}

		[Ordinal(16)] [RED("isFadeEndFadeIn")] 		public CBool IsFadeEndFadeIn { get; set;}

		public CStaticCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStaticCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}