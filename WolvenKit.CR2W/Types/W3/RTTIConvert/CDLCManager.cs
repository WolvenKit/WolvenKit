using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDLCManager : CObject
	{
		[RED("definitions", 2,0)] 		public CArray<CHandle<CDLCDefinition>> Definitions { get; set;}

		[RED("mountedContent", 2,0)] 		public CArray<CHandle<IGameplayDLCMounter>> MountedContent { get; set;}

		public CDLCManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDLCManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}