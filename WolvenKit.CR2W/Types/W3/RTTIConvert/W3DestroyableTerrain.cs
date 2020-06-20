using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DestroyableTerrain : CInteractiveEntity
	{
		[RED("m_numOfPiecesToDestroy")] 		public CInt32 M_numOfPiecesToDestroy { get; set;}

		[RED("m_timeBetweenRandomDestroyMin")] 		public CInt32 M_timeBetweenRandomDestroyMin { get; set;}

		[RED("m_timeBetweenRandomDestroyMax")] 		public CInt32 M_timeBetweenRandomDestroyMax { get; set;}

		public W3DestroyableTerrain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DestroyableTerrain(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}