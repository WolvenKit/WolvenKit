using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCrowdCreationDataRegistry : ISerializable
	{
		[Ordinal(0)] [RED("creationData")] public CArray<gameCrowdCreationData> CreationData { get; set; }

		public gameCrowdCreationDataRegistry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
