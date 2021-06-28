using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDLCManager : CObject
	{
		[Ordinal(1)] [RED("definitions", 2,0)] 		public CArray<CHandle<CDLCDefinition>> Definitions { get; set;}

		[Ordinal(2)] [RED("mountedContent", 2,0)] 		public CArray<CHandle<IGameplayDLCMounter>> MountedContent { get; set;}

		public CDLCManager(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}