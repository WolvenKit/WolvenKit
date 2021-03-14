using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WidgetHudComponentInterface : WidgetBaseComponent
	{
		private rRef<inkHudEntriesResource> _hudEntriesResource;
		private rRef<CMaterialTemplate> _externalMaterial;
		private CHandle<worlduiMeshTargetBinding> _meshTargetBinding;

		[Ordinal(5)] 
		[RED("hudEntriesResource")] 
		public rRef<inkHudEntriesResource> HudEntriesResource
		{
			get
			{
				if (_hudEntriesResource == null)
				{
					_hudEntriesResource = (rRef<inkHudEntriesResource>) CR2WTypeManager.Create("rRef:inkHudEntriesResource", "hudEntriesResource", cr2w, this);
				}
				return _hudEntriesResource;
			}
			set
			{
				if (_hudEntriesResource == value)
				{
					return;
				}
				_hudEntriesResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		public WidgetHudComponentInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
