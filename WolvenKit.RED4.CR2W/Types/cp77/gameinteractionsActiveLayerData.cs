using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsActiveLayerData : CVariable
	{
		private wCHandle<gameObject> _activator;
		private CName _linkedLayersName;
		private CName _layerName;

		[Ordinal(0)] 
		[RED("activator")] 
		public wCHandle<gameObject> Activator
		{
			get => GetProperty(ref _activator);
			set => SetProperty(ref _activator, value);
		}

		[Ordinal(1)] 
		[RED("linkedLayersName")] 
		public CName LinkedLayersName
		{
			get => GetProperty(ref _linkedLayersName);
			set => SetProperty(ref _linkedLayersName, value);
		}

		[Ordinal(2)] 
		[RED("layerName")] 
		public CName LayerName
		{
			get => GetProperty(ref _layerName);
			set => SetProperty(ref _layerName, value);
		}

		public gameinteractionsActiveLayerData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
