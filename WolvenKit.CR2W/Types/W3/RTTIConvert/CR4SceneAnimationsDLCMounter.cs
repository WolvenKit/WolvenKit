using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4SceneAnimationsDLCMounter : IGameplayDLCMounter
	{
		[RED("sceneAnimationsBodyFilePath")] 		public CString SceneAnimationsBodyFilePath { get; set;}

		[RED("sceneAnimationsMimicsFilePath")] 		public CString SceneAnimationsMimicsFilePath { get; set;}

		[RED("sceneAnimationsMimicsEmoStatesFilePath")] 		public CString SceneAnimationsMimicsEmoStatesFilePath { get; set;}

		public CR4SceneAnimationsDLCMounter(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CR4SceneAnimationsDLCMounter(cr2w);

	}
}