using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDestroyEntityDef : IBehTreeTaskDefinition
	{
		[RED("entityTag")] 		public CName EntityTag { get; set;}

		[RED("playEffectName")] 		public CName PlayEffectName { get; set;}

		[RED("stopEffectName")] 		public CName StopEffectName { get; set;}

		[RED("eventToRaise")] 		public CName EventToRaise { get; set;}

		[RED("playEffect")] 		public CBool PlayEffect { get; set;}

		[RED("stopEffect")] 		public CBool StopEffect { get; set;}

		[RED("destroyAfter")] 		public CFloat DestroyAfter { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		public CBTTaskDestroyEntityDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDestroyEntityDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}