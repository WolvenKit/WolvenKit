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
			get
			{
				if (_collection == null)
				{
					_collection = (CHandle<physicsDeferredCollection>) CR2WTypeManager.Create("handle:physicsDeferredCollection", "collection", cr2w, this);
				}
				return _collection;
			}
			set
			{
				if (_collection == value)
				{
					return;
				}
				_collection = value;
				PropertySet(this);
			}
		}

		public meshMeshParamCompiledPhysics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
