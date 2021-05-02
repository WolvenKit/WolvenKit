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
			get => GetProperty(ref _layerDefinitions);
			set => SetProperty(ref _layerDefinitions, value);
		}

		[Ordinal(2)] 
		[RED("preGameLayerDefinitions")] 
		public inkLayerDefinitionCollection PreGameLayerDefinitions
		{
			get => GetProperty(ref _preGameLayerDefinitions);
			set => SetProperty(ref _preGameLayerDefinitions, value);
		}

		[Ordinal(3)] 
		[RED("permanentLayerDefinitions")] 
		public inkPermanentLayerDefinitionCollection PermanentLayerDefinitions
		{
			get => GetProperty(ref _permanentLayerDefinitions);
			set => SetProperty(ref _permanentLayerDefinitions, value);
		}

		public inkLayersResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
