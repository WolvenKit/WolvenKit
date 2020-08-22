using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphScriptStateNode : CBehaviorGraphStateNode
	{
		[RED("nameAsName")] 		public CName NameAsName { get; set;}

		[RED("activationScriptEvent")] 		public CName ActivationScriptEvent { get; set;}

		[RED("deactivationScriptEvent")] 		public CName DeactivationScriptEvent { get; set;}

		[RED("becomesCurrentStateScriptEvent")] 		public CName BecomesCurrentStateScriptEvent { get; set;}

		[RED("noLongerCurrentStateScriptEvent")] 		public CName NoLongerCurrentStateScriptEvent { get; set;}

		[RED("fullyBlendedInScriptEvent")] 		public CName FullyBlendedInScriptEvent { get; set;}

		public CBehaviorGraphScriptStateNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphScriptStateNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}