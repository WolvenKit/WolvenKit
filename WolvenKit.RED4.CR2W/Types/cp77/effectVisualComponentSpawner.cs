using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectVisualComponentSpawner : effectSpawner
	{
		private CArray<CName> _componentName;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CArray<CName> ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		public effectVisualComponentSpawner(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
