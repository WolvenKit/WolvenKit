using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModSbUiAnimationSequencer : CObject
	{
		[Ordinal(1)] [RED("seqInstances", 2,0)] 		public CArray<CHandle<CModSbUiAnimSequence>> SeqInstances { get; set;}

		[Ordinal(2)] [RED("masterEntity")] 		public CHandle<CGameplayEntity> MasterEntity { get; set;}

		[Ordinal(3)] [RED("animDirector")] 		public CHandle<CModStoryBoardAnimationDirector> AnimDirector { get; set;}

		public CModSbUiAnimationSequencer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModSbUiAnimationSequencer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}