using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseVisibleObjectComponent : entIPlacedComponent
	{
		private CHandle<senseVisibleObject> _visibleObject;

		[Ordinal(5)] 
		[RED("visibleObject")] 
		public CHandle<senseVisibleObject> VisibleObject
		{
			get => GetProperty(ref _visibleObject);
			set => SetProperty(ref _visibleObject, value);
		}

		public senseVisibleObjectComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
