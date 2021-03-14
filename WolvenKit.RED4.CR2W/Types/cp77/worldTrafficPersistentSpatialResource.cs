using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentSpatialResource : resStreamedResource
	{
		private CArray<CArray<CUInt16>> _neighborGroups;

		[Ordinal(1)] 
		[RED("neighborGroups")] 
		public CArray<CArray<CUInt16>> NeighborGroups
		{
			get
			{
				if (_neighborGroups == null)
				{
					_neighborGroups = (CArray<CArray<CUInt16>>) CR2WTypeManager.Create("array:array:Uint16", "neighborGroups", cr2w, this);
				}
				return _neighborGroups;
			}
			set
			{
				if (_neighborGroups == value)
				{
					return;
				}
				_neighborGroups = value;
				PropertySet(this);
			}
		}

		public worldTrafficPersistentSpatialResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
