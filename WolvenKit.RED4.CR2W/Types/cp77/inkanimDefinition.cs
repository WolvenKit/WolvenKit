using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimDefinition : IScriptable
	{
		private CArray<CHandle<inkanimInterpolator>> _interpolators;
		private CArray<CHandle<inkanimEvent>> _events;

		[Ordinal(0)] 
		[RED("interpolators")] 
		public CArray<CHandle<inkanimInterpolator>> Interpolators
		{
			get => GetProperty(ref _interpolators);
			set => SetProperty(ref _interpolators, value);
		}

		[Ordinal(1)] 
		[RED("events")] 
		public CArray<CHandle<inkanimEvent>> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}

		public inkanimDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
