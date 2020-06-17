using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardCameraDofSettings : CVariable
	{
		[RED("strength")] 		public CFloat Strength { get; set;}

		[RED("blurNear")] 		public CFloat BlurNear { get; set;}

		[RED("blurFar")] 		public CFloat BlurFar { get; set;}

		[RED("focusNear")] 		public CFloat FocusNear { get; set;}

		[RED("focusFar")] 		public CFloat FocusFar { get; set;}

		public SStoryBoardCameraDofSettings(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SStoryBoardCameraDofSettings(cr2w);

	}
}