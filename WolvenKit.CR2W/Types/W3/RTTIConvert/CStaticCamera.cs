using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStaticCamera : CCamera
	{
		[RED("solver")] 		public CEnum<ECameraSolver> Solver { get; set;}

		[RED("activationDuration")] 		public CFloat ActivationDuration { get; set;}

		[RED("deactivationDuration")] 		public CFloat DeactivationDuration { get; set;}

		[RED("timeout")] 		public CFloat Timeout { get; set;}

		[RED("zoom")] 		public CFloat Zoom { get; set;}

		[RED("fov")] 		public CFloat Fov { get; set;}

		[RED("animState")] 		public CInt32 AnimState { get; set;}

		[RED("guiEffect")] 		public CInt32 GuiEffect { get; set;}

		[RED("blockPlayer")] 		public CBool BlockPlayer { get; set;}

		[RED("resetPlayerCamera")] 		public CBool ResetPlayerCamera { get; set;}

		[RED("fadeStartDuration")] 		public CFloat FadeStartDuration { get; set;}

		[RED("fadeStartColor")] 		public CColor FadeStartColor { get; set;}

		[RED("isFadeStartFadeIn")] 		public CBool IsFadeStartFadeIn { get; set;}

		[RED("fadeEndDuration")] 		public CFloat FadeEndDuration { get; set;}

		[RED("fadeEndColor")] 		public CColor FadeEndColor { get; set;}

		[RED("isFadeEndFadeIn")] 		public CBool IsFadeEndFadeIn { get; set;}

		public CStaticCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStaticCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}