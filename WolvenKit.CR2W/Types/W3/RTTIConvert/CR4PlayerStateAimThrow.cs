using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateAimThrow : CR4PlayerStateExtendedMovable
	{
		[RED("camera")] 		public CHandle<CCustomCamera> Camera { get; set;}

		[RED("fovVel")] 		public CFloat FovVel { get; set;}

		[RED("initialPitch")] 		public CFloat InitialPitch { get; set;}

		[RED("cachedHorTimeout")] 		public CFloat CachedHorTimeout { get; set;}

		[RED("cachedVerTimeout")] 		public CFloat CachedVerTimeout { get; set;}

		[RED("prevState")] 		public CName PrevState { get; set;}

		[RED("followTarget")] 		public CBool FollowTarget { get; set;}

		[RED("followPitch")] 		public CFloat FollowPitch { get; set;}

		[RED("isRotating")] 		public CBool IsRotating { get; set;}

		public CR4PlayerStateAimThrow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateAimThrow(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}