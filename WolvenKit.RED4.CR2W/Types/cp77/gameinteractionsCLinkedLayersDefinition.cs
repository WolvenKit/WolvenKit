using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCLinkedLayersDefinition : gameinteractionsNodeDefinition
	{
		private CArray<CHandle<gameinteractionsCHotSpotLayerDefinition>> _layersDefinitions;
		private CHandle<gameinteractionsvisIVisualizerDefinition> _visualizerDefinition;
		private CName _tag;

		[Ordinal(0)] 
		[RED("layersDefinitions")] 
		public CArray<CHandle<gameinteractionsCHotSpotLayerDefinition>> LayersDefinitions
		{
			get
			{
				if (_layersDefinitions == null)
				{
					_layersDefinitions = (CArray<CHandle<gameinteractionsCHotSpotLayerDefinition>>) CR2WTypeManager.Create("array:handle:gameinteractionsCHotSpotLayerDefinition", "layersDefinitions", cr2w, this);
				}
				return _layersDefinitions;
			}
			set
			{
				if (_layersDefinitions == value)
				{
					return;
				}
				_layersDefinitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visualizerDefinition")] 
		public CHandle<gameinteractionsvisIVisualizerDefinition> VisualizerDefinition
		{
			get
			{
				if (_visualizerDefinition == null)
				{
					_visualizerDefinition = (CHandle<gameinteractionsvisIVisualizerDefinition>) CR2WTypeManager.Create("handle:gameinteractionsvisIVisualizerDefinition", "visualizerDefinition", cr2w, this);
				}
				return _visualizerDefinition;
			}
			set
			{
				if (_visualizerDefinition == value)
				{
					return;
				}
				_visualizerDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		public gameinteractionsCLinkedLayersDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
