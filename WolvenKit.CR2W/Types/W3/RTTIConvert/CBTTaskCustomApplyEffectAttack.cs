using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCustomApplyEffectAttack : CBTTaskAttack
	{
		[RED("applyEffectInterval")] 		public CFloat ApplyEffectInterval { get; set;}

		[RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[RED("activationTimeStamp")] 		public CFloat ActivationTimeStamp { get; set;}

		[RED("activated")] 		public CBool Activated { get; set;}

		public CBTTaskCustomApplyEffectAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCustomApplyEffectAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}