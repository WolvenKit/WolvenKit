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
			get
			{
				if (_setup == null)
				{
					_setup = (worldHeatmapSetup) CR2WTypeManager.Create("worldHeatmapSetup", "setup", cr2w, this);
				}
				return _setup;
			}
			set
			{
				if (_setup == value)
				{
					return;
				}
				_setup = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("layerNames")] 
		public CArray<CString> LayerNames
		{
			get
			{
				if (_layerNames == null)
				{
					_layerNames = (CArray<CString>) CR2WTypeManager.Create("array:String", "layerNames", cr2w, this);
				}
				return _layerNames;
			}
			set
			{
				if (_layerNames == value)
				{
					return;
				}
				_layerNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("layers")] 
		public CArray<raRef<worldHeatmapLayer>> Layers
		{
			get
			{
				if (_layers == null)
				{
					_layers = (CArray<raRef<worldHeatmapLayer>>) CR2WTypeManager.Create("array:raRef:worldHeatmapLayer", "layers", cr2w, this);
				}
				return _layers;
			}
			set
			{
				if (_layers == value)
				{
					return;
				}
				_layers = value;
				PropertySet(this);
			}
		}

		public worldHeatmapResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
