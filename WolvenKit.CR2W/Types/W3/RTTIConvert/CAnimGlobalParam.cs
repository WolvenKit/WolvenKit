using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimGlobalParam : CEntityTemplateParam
	{
		[RED("skeletonType")] 		public CEnum<ESkeletonType> SkeletonType { get; set;}

		[RED("defaultAnimationName")] 		public CName DefaultAnimationName { get; set;}

		[RED("customMimicsFilter_Full")] 		public CName CustomMimicsFilter_Full { get; set;}

		[RED("customMimicsFilter_Lipsync")] 		public CName CustomMimicsFilter_Lipsync { get; set;}

		[RED("animTag")] 		public CName AnimTag { get; set;}

		[RED("sfxTag")] 		public CName SfxTag { get; set;}

		public CAnimGlobalParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimGlobalParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}