using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WidgetMenuComponentInterface : WidgetBaseComponent
	{
		private rRef<inkWidgetLibraryResource> _widgetResource;
		private rRef<inkWidgetLibraryResource> _cursorResource;
		private rRef<CMaterialTemplate> _externalMaterial;
		private CHandle<worlduiMeshTargetBinding> _meshTargetBinding;

		[Ordinal(5)] 
		[RED("widgetResource")] 
		public rRef<inkWidgetLibraryResource> WidgetResource
		{
			get
			{
				if (_widgetResource == null)
				{
					_widgetResource = (rRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("rRef:inkWidgetLibraryResource", "widgetResource", cr2w, this);
				}
				return _widgetResource;
			}
			set
			{
				if (_widgetResource == value)
				{
					return;
				}
				_widgetResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("cursorResource")] 
		public rRef<inkWidgetLibraryResource> CursorResource
		{
			get
			{
				if (_cursorResource == null)
				{
					_cursorResource = (rRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("rRef:inkWidgetLibraryResource", "cursorResource", cr2w, this);
				}
				return _cursorResource;
			}
			set
			{
				if (_cursorResource == value)
				{
					return;
				}
				_cursorResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("externalMaterial")] 
		public rRef<CMaterialTemplate> ExternalMaterial
		{
			get
			{
				if (_externalMaterial == null)
				{
					_externalMaterial = (rRef<CMaterialTemplate>) CR2WTypeManager.Create("rRef:CMaterialTemplate", "externalMaterial", cr2w, this);
				}
				return _externalMaterial;
			}
			set
			{
				if (_externalMaterial == value)
				{
					return;
				}
				_externalMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("meshTargetBinding")] 
		public CHandle<worlduiMeshTargetBinding> MeshTargetBinding
		{
			get
			{
				if (_meshTargetBinding == null)
				{
					_meshTargetBinding = (CHandle<worlduiMeshTargetBinding>) CR2WTypeManager.Create("handle:worlduiMeshTargetBinding", "meshTargetBinding", cr2w, this);
				}
				return _meshTargetBinding;
			}
			set
			{
				if (_meshTargetBinding == value)
				{
					return;
				}
				_meshTargetBinding = value;
				PropertySet(this);
			}
		}

		public WidgetMenuComponentInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
