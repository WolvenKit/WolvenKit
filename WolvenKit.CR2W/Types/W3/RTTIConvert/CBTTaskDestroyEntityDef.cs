using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDestroyEntityDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("entityTag")] 		public CName EntityTag { get; set;}

		[Ordinal(2)] [RED("playEffectName")] 		public CName PlayEffectName { get; set;}

		[Ordinal(3)] [RED("stopEffectName")] 		public CName StopEffectName { get; set;}

		[Ordinal(4)] [RED("eventToRaise")] 		public CName EventToRaise { get; set;}

		[Ordinal(5)] [RED("playEffect")] 		public CBool PlayEffect { get; set;}

		[Ordinal(6)] [RED("stopEffect")] 		public CBool StopEffect { get; set;}

		[Ordinal(7)] [RED("destroyAfter")] 		public CFloat DestroyAfter { get; set;}

		[Ordinal(8)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(9)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		public CBTTaskDestroyEntityDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDestroyEntityDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}