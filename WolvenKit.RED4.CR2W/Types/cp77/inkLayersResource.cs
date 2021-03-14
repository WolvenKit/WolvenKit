using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLayersResource : CResource
	{
		private inkLayerDefinitionCollection _layerDefinitions;
		private inkLayerDefinitionCollection _preGameLayerDefinitions;
		private inkPermanentLayerDefinitionCollection _permanentLayerDefinitions;

		[Ordinal(1)] 
		[RED("layerDefinitions")] 
		public inkLayerDefinitionCollection LayerDefinitions
		{
			get
			{
				if (_layerDefinitions == null)
				{
					_layerDefinitions = (inkLayerDefinitionCollection) CR2WTypeManager.Create("inkLayerDefinitionCollection", "layerDefinitions", cr2w, this);
				}
				return _layerDefinitions;
			}
			set
			{
				if (_layerDefinitions == value)
				{
					return;
				}
				_layerDefinitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("preGameLayerDefinitions")] 
		public inkLayerDefinitionCollection PreGameLayerDefinitions
		{
			get
			{
				if (_preGameLayerDefinitions == null)
				{
					_preGameLayerDefinitions = (inkLayerDefinitionCollection) CR2WTypeManager.Create("inkLayerDefinitionCollection", "preGameLayerDefinitions", cr2w, this);
				}
				return _preGameLayerDefinitions;
			}
			set
			{
				if (_preGameLayerDefinitions == value)
				{
					return;
				}
				_preGameLayerDefinitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("permanentLayerDefinitions")] 
		public inkPermanentLayerDefinitionCollection PermanentLayerDefinitions
		{
			get
			{
				if (_permanentLayerDefinitions == null)
				{
					_permanentLayerDefinitions = (inkPermanentLayerDefinitionCollection) CR2WTypeManager.Create("inkPermanentLayerDefinitionCollection", "permanentLayerDefinitions", cr2w, this);
				}
				return _permanentLayerDefinitions;
			}
			set
			{
				if (_permanentLayerDefinitions == value)
				{
					return;
				}
				_permanentLayerDefinitions = value;
				PropertySet(this);
			}
		}

		public inkLayersResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
