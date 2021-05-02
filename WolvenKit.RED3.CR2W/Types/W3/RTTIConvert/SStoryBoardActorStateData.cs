using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardActorStateData : CVariable
	{
		[Ordinal(1)] [RED("id")] 		public CString Id { get; set;}

		[Ordinal(2)] [RED("assetname")] 		public CString Assetname { get; set;}

		[Ordinal(3)] [RED("userSetName")] 		public CBool UserSetName { get; set;}

		[Ordinal(4)] [RED("templatePath")] 		public CString TemplatePath { get; set;}

		[Ordinal(5)] [RED("appearanceId")] 		public CInt32 AppearanceId { get; set;}

		[Ordinal(6)] [RED("defaultIdleAnim")] 		public CName DefaultIdleAnim { get; set;}

		public SStoryBoardActorStateData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}