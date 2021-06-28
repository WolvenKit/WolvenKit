using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnBeingNoticed : redEvent
	{
		private wCHandle<gameObject> _objectThatNoticed;

		[Ordinal(0)] 
		[RED("objectThatNoticed")] 
		public wCHandle<gameObject> ObjectThatNoticed
		{
			get => GetProperty(ref _objectThatNoticed);
			set => SetProperty(ref _objectThatNoticed, value);
		}

		public OnBeingNoticed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
