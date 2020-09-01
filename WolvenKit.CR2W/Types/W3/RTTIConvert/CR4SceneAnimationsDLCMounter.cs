using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4SceneAnimationsDLCMounter : IGameplayDLCMounter
	{
		[Ordinal(1)] [RED("sceneAnimationsBodyFilePath")] 		public CString SceneAnimationsBodyFilePath { get; set;}

		[Ordinal(2)] [RED("sceneAnimationsMimicsFilePath")] 		public CString SceneAnimationsMimicsFilePath { get; set;}

		[Ordinal(3)] [RED("sceneAnimationsMimicsEmoStatesFilePath")] 		public CString SceneAnimationsMimicsEmoStatesFilePath { get; set;}

		public CR4SceneAnimationsDLCMounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4SceneAnimationsDLCMounter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}