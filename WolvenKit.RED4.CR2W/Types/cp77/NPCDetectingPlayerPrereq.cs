using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCDetectingPlayerPrereq : gameIScriptablePrereq
	{
		private CFloat _threshold;

		[Ordinal(0)] 
		[RED("threshold")] 
		public CFloat Threshold
		{
			get => GetProperty(ref _threshold);
			set => SetProperty(ref _threshold, value);
		}

		public NPCDetectingPlayerPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
