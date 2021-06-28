using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UILocalizationMap : IScriptable
	{
		private CArray<UILocRecord> _map;

		[Ordinal(0)] 
		[RED("map")] 
		public CArray<UILocRecord> Map
		{
			get => GetProperty(ref _map);
			set => SetProperty(ref _map, value);
		}

		public UILocalizationMap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
