using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStoryScenePlayer : CEntity
	{
		[Ordinal(1)] [RED("storyScene")] 		public CHandle<CStoryScene> StoryScene { get; set;}

		[Ordinal(2)] [RED("injectedScenes", 2,0)] 		public CArray<CHandle<CStoryScene>> InjectedScenes { get; set;}

		[Ordinal(3)] [RED("isPaused")] 		public CUInt16 IsPaused { get; set;}

		[Ordinal(4)] [RED("isGameplay")] 		public CBool IsGameplay { get; set;}

		[Ordinal(5)] [RED("m_isFinalboard")] 		public CBool M_isFinalboard { get; set;}

		public CStoryScenePlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStoryScenePlayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}