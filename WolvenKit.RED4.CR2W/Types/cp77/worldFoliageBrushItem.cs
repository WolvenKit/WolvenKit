using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageBrushItem : ISerializable
	{
		private rRef<CMesh> _mesh;
		private CName _meshAppearance;
		private worldFoliageBrushParams _params;
		private CBool _selected;

		[Ordinal(0)] 
		[RED("Mesh")] 
		public rRef<CMesh> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (rRef<CMesh>) CR2WTypeManager.Create("rRef:CMesh", "Mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("MeshAppearance")] 
		public CName MeshAppearance
		{
			get
			{
				if (_meshAppearance == null)
				{
					_meshAppearance = (CName) CR2WTypeManager.Create("CName", "MeshAppearance", cr2w, this);
				}
				return _meshAppearance;
			}
			set
			{
				if (_meshAppearance == value)
				{
					return;
				}
				_meshAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Params")] 
		public worldFoliageBrushParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (worldFoliageBrushParams) CR2WTypeManager.Create("worldFoliageBrushParams", "Params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Selected")] 
		public CBool Selected
		{
			get
			{
				if (_selected == null)
				{
					_selected = (CBool) CR2WTypeManager.Create("Bool", "Selected", cr2w, this);
				}
				return _selected;
			}
			set
			{
				if (_selected == value)
				{
					return;
				}
				_selected = value;
				PropertySet(this);
			}
		}

		public worldFoliageBrushItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
