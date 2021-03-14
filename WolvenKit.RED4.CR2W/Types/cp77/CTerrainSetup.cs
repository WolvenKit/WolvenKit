using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CTerrainSetup : CResource
	{
		private CArray<CFloat> _tiling;
		private CArray<CName> _physicalMaterial;

		[Ordinal(1)] 
		[RED("tiling")] 
		public CArray<CFloat> Tiling
		{
			get
			{
				if (_tiling == null)
				{
					_tiling = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "tiling", cr2w, this);
				}
				return _tiling;
			}
			set
			{
				if (_tiling == value)
				{
					return;
				}
				_tiling = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("physicalMaterial")] 
		public CArray<CName> PhysicalMaterial
		{
			get
			{
				if (_physicalMaterial == null)
				{
					_physicalMaterial = (CArray<CName>) CR2WTypeManager.Create("array:CName", "physicalMaterial", cr2w, this);
				}
				return _physicalMaterial;
			}
			set
			{
				if (_physicalMaterial == value)
				{
					return;
				}
				_physicalMaterial = value;
				PropertySet(this);
			}
		}

		public CTerrainSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
