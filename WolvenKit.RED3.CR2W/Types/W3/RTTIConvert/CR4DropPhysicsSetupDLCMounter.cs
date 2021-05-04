using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4DropPhysicsSetupDLCMounter : IGameplayDLCMounter
	{
		[Ordinal(1)] [RED("entityTemplatePaths", 2,0)] 		public CArray<CString> EntityTemplatePaths { get; set;}

		[Ordinal(2)] [RED("dropSetups", 2,0)] 		public CArray<CHandle<CDropPhysicsSetup>> DropSetups { get; set;}

		public CR4DropPhysicsSetupDLCMounter(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}