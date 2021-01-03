using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamCompiledPhysics : meshMeshParameter
	{
		[Ordinal(0)]  [RED("collection")] public CHandle<physicsDeferredCollection> Collection { get; set; }

		public meshMeshParamCompiledPhysics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
