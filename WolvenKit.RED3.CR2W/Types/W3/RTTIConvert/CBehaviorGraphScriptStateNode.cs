using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphScriptStateNode : CBehaviorGraphStateNode
	{
		[Ordinal(1)] [RED("nameAsName")] 		public CName NameAsName { get; set;}

		[Ordinal(2)] [RED("activationScriptEvent")] 		public CName ActivationScriptEvent { get; set;}

		[Ordinal(3)] [RED("deactivationScriptEvent")] 		public CName DeactivationScriptEvent { get; set;}

		[Ordinal(4)] [RED("becomesCurrentStateScriptEvent")] 		public CName BecomesCurrentStateScriptEvent { get; set;}

		[Ordinal(5)] [RED("noLongerCurrentStateScriptEvent")] 		public CName NoLongerCurrentStateScriptEvent { get; set;}

		[Ordinal(6)] [RED("fullyBlendedInScriptEvent")] 		public CName FullyBlendedInScriptEvent { get; set;}

		public CBehaviorGraphScriptStateNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphScriptStateNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}