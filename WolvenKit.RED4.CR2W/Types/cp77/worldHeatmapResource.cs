using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldHeatmapResource : CResource
	{
		private worldHeatmapSetup _setup;
		private CString _name;
		private CArray<CString> _layerNames;
		private CArray<raRef<worldHeatmapLayer>> _layers;

		[Ordinal(1)] 
		[RED("setup")] 
		public worldHeatmapSetup Setup
		{
			get => GetProperty(ref _setup);
			set => SetProperty(ref _setup, value);
		}

		[Ordinal(2)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(3)] 
		[RED("layerNames")] 
		public CArray<CString> LayerNames
		{
			get => GetProperty(ref _layerNames);
			set => SetProperty(ref _layerNames, value);
		}

		[Ordinal(4)] 
		[RED("layers")] 
		public CArray<raRef<worldHeatmapLayer>> Layers
		{
			get => GetProperty(ref _layers);
			set => SetProperty(ref _layers, value);
		}

		public worldHeatmapResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
