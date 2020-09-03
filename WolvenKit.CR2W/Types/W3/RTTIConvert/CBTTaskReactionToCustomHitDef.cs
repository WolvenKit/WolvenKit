using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskReactionToCustomHitDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(2)] [RED("waitTimeout")] 		public CFloat WaitTimeout { get; set;}

		[Ordinal(3)] [RED("activationTimeout")] 		public CFloat ActivationTimeout { get; set;}

		[Ordinal(4)] [RED("activationScriptEvent")] 		public CName ActivationScriptEvent { get; set;}

		[Ordinal(5)] [RED("deactivateScriptEvent")] 		public CName DeactivateScriptEvent { get; set;}

		public CBTTaskReactionToCustomHitDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskReactionToCustomHitDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}