using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageBuffImmunity : IBehTreeTask
	{
		[Ordinal(1)] [RED("effects", 2,0)] 		public CArray<CEnum<EEffectType>> Effects { get; set;}

		[Ordinal(2)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(3)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(4)] [RED("bRemove")] 		public CBool BRemove { get; set;}

		[Ordinal(5)] [RED("removeFromTemplate")] 		public CBool RemoveFromTemplate { get; set;}

		public CBTTaskManageBuffImmunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskManageBuffImmunity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}