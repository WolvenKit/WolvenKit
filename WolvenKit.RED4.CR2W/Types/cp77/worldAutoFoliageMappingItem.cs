using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAutoFoliageMappingItem : CVariable
	{
		private CName _material;
		private CUInt32 _layerIndex;
		private raRef<worldFoliageBrush> _foliageBrush;

		[Ordinal(0)] 
		[RED("Material")] 
		public CName Material
		{
			get
			{
				if (_material == null)
				{
					_material = (CName) CR2WTypeManager.Create("CName", "Material", cr2w, this);
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

		[Ordinal(1)] 
		[RED("LayerIndex")] 
		public CUInt32 LayerIndex
		{
			get
			{
				if (_layerIndex == null)
				{
					_layerIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "LayerIndex", cr2w, this);
				}
				return _layerIndex;
			}
			set
			{
				if (_layerIndex == value)
				{
					return;
				}
				_layerIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("FoliageBrush")] 
		public raRef<worldFoliageBrush> FoliageBrush
		{
			get
			{
				if (_foliageBrush == null)
				{
					_foliageBrush = (raRef<worldFoliageBrush>) CR2WTypeManager.Create("raRef:worldFoliageBrush", "FoliageBrush", cr2w, this);
				}
				return _foliageBrush;
			}
			set
			{
				if (_foliageBrush == value)
				{
					return;
				}
				_foliageBrush = value;
				PropertySet(this);
			}
		}

		public worldAutoFoliageMappingItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
