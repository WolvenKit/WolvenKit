using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamCompiledPhysics : meshMeshParameter
	{
		private CHandle<physicsDeferredCollection> _collection;

		[Ordinal(0)] 
		[RED("collection")] 
		public CHandle<physicsDeferredCollection> Collection
		{
			get => GetProperty(ref _collection);
			set => SetProperty(ref _collection, value);
		}

		public meshMeshParamCompiledPhysics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
