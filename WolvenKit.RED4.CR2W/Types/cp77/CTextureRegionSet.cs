using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CTextureRegionSet : CResource
	{
		private CArray<rendTextureRegion> _regions;

		[Ordinal(1)] 
		[RED("regions")] 
		public CArray<rendTextureRegion> Regions
		{
			get
			{
				if (_regions == null)
				{
					_regions = (CArray<rendTextureRegion>) CR2WTypeManager.Create("array:rendTextureRegion", "regions", cr2w, this);
				}
				return _regions;
			}
			set
			{
				if (_regions == value)
				{
					return;
				}
				_regions = value;
				PropertySet(this);
			}
		}

		public CTextureRegionSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
