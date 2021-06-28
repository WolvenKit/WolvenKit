using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporalPrereq : gameIScriptablePrereq
	{
		private CFloat _totalDuration;

		[Ordinal(0)] 
		[RED("totalDuration")] 
		public CFloat TotalDuration
		{
			get => GetProperty(ref _totalDuration);
			set => SetProperty(ref _totalDuration, value);
		}

		public TemporalPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
