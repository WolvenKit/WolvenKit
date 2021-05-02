using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimEvent : IScriptable
	{
		private CFloat _startTime;

		[Ordinal(0)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}

		public inkanimEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
