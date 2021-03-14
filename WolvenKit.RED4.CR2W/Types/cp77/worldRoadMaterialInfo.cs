using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRoadMaterialInfo : CVariable
	{
		private CFloat _startOffset;
		private CEnum<worldRoadMaterial> _material;

		[Ordinal(0)] 
		[RED("startOffset")] 
		public CFloat StartOffset
		{
			get
			{
				if (_startOffset == null)
				{
					_startOffset = (CFloat) CR2WTypeManager.Create("Float", "startOffset", cr2w, this);
				}
				return _startOffset;
			}
			set
			{
				if (_startOffset == value)
				{
					return;
				}
				_startOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("material")] 
		public CEnum<worldRoadMaterial> Material
		{
			get
			{
				if (_material == null)
				{
					_material = (CEnum<worldRoadMaterial>) CR2WTypeManager.Create("worldRoadMaterial", "material", cr2w, this);
				}
				return _material;
			}
			set
			{
				if (_material == value)
				{
					return;
				}
				_material = value;
				PropertySet(this);
			}
		}

		public worldRoadMaterialInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
