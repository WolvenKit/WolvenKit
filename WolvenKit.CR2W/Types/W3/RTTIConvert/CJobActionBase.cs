using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJobActionBase : CObject
	{
		[RED("categoryName")] 		public CString CategoryName { get; set;}

		[RED("animName")] 		public CName AnimName { get; set;}

		[RED("animBlendIn")] 		public CFloat AnimBlendIn { get; set;}

		[RED("animBlendOut")] 		public CFloat AnimBlendOut { get; set;}

		[RED("fireBlendedEvents")] 		public CBool FireBlendedEvents { get; set;}

		[RED("allowedLookAtLevel")] 		public CEnum<ELookAtLevel> AllowedLookAtLevel { get; set;}

		[RED("ignoreIfItemMounted")] 		public CName IgnoreIfItemMounted { get; set;}

		[RED("isSkippable")] 		public CBool IsSkippable { get; set;}

		public CJobActionBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJobActionBase(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}