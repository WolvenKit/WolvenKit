using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsComponent : entIPlacedComponent
	{
		private rRef<gameinteractionsInteractionDescriptorResource> _definitionResource;
		private Vector3 _interactionRootOffset;
		private CArray<gameinteractionsInteractionDefinitionOverrider> _layerOverrides;
		private CArray<gameinteractionsInteractionDefinitionOverrider> _layerOverridesTemp;
		private CBool _isEnabled;

		[Ordinal(5)] 
		[RED("definitionResource")] 
		public rRef<gameinteractionsInteractionDescriptorResource> DefinitionResource
		{
			get
			{
				if (_definitionResource == null)
				{
					_definitionResource = (rRef<gameinteractionsInteractionDescriptorResource>) CR2WTypeManager.Create("rRef:gameinteractionsInteractionDescriptorResource", "definitionResource", cr2w, this);
				}
				return _definitionResource;
			}
			set
			{
				if (_definitionResource == value)
				{
					return;
				}
				_definitionResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("interactionRootOffset")] 
		public Vector3 InteractionRootOffset
		{
			get
			{
				if (_interactionRootOffset == null)
				{
					_interactionRootOffset = (Vector3) CR2WTypeManager.Create("Vector3", "interactionRootOffset", cr2w, this);
				}
				return _interactionRootOffset;
			}
			set
			{
				if (_interactionRootOffset == value)
				{
					return;
				}
				_interactionRootOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("layerOverrides")] 
		public CArray<gameinteractionsInteractionDefinitionOverrider> LayerOverrides
		{
			get
			{
				if (_layerOverrides == null)
				{
					_layerOverrides = (CArray<gameinteractionsInteractionDefinitionOverrider>) CR2WTypeManager.Create("array:gameinteractionsInteractionDefinitionOverrider", "layerOverrides", cr2w, this);
				}
				return _layerOverrides;
			}
			set
			{
				if (_layerOverrides == value)
				{
					return;
				}
				_layerOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("layerOverridesTemp")] 
		public CArray<gameinteractionsInteractionDefinitionOverrider> LayerOverridesTemp
		{
			get
			{
				if (_layerOverridesTemp == null)
				{
					_layerOverridesTemp = (CArray<gameinteractionsInteractionDefinitionOverrider>) CR2WTypeManager.Create("array:gameinteractionsInteractionDefinitionOverrider", "layerOverridesTemp", cr2w, this);
				}
				return _layerOverridesTemp;
			}
			set
			{
				if (_layerOverridesTemp == value)
				{
					return;
				}
				_layerOverridesTemp = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public gameinteractionsComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
