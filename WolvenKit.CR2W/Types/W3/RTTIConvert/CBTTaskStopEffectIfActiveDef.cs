using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskStopEffectIfActiveDef : IBehTreeTaskDefinition
	{
		[RED("effectName")] 		public CName EffectName { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("allEffects")] 		public CBool AllEffects { get; set;}

		[RED("findActorByTag")] 		public CBool FindActorByTag { get; set;}

		[RED("tagToFind")] 		public CName TagToFind { get; set;}

		public CBTTaskStopEffectIfActiveDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskStopEffectIfActiveDef(cr2w);

	}
}