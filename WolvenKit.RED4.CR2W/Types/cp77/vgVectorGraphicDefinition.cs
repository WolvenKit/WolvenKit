using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicDefinition : ISerializable
	{
		private CHandle<vgVectorGraphicShape_Group> _rootShapeGroup;
		private Vector2 _dimensions;

		[Ordinal(0)] 
		[RED("rootShapeGroup")] 
		public CHandle<vgVectorGraphicShape_Group> RootShapeGroup
		{
			get
			{
				if (_rootShapeGroup == null)
				{
					_rootShapeGroup = (CHandle<vgVectorGraphicShape_Group>) CR2WTypeManager.Create("handle:vgVectorGraphicShape_Group", "rootShapeGroup", cr2w, this);
				}
				return _rootShapeGroup;
			}
			set
			{
				if (_rootShapeGroup == value)
				{
					return;
				}
				_rootShapeGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("dimensions")] 
		public Vector2 Dimensions
		{
			get
			{
				if (_dimensions == null)
				{
					_dimensions = (Vector2) CR2WTypeManager.Create("Vector2", "dimensions", cr2w, this);
				}
				return _dimensions;
			}
			set
			{
				if (_dimensions == value)
				{
					return;
				}
				_dimensions = value;
				PropertySet(this);
			}
		}

		public vgVectorGraphicDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
