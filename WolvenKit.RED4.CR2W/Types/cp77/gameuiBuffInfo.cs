using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBuffInfo : CVariable
	{
		private TweakDBID _buffID;
		private CFloat _timeRemaining;

		[Ordinal(0)] 
		[RED("buffID")] 
		public TweakDBID BuffID
		{
			get => GetProperty(ref _buffID);
			set => SetProperty(ref _buffID, value);
		}

		[Ordinal(1)] 
		[RED("timeRemaining")] 
		public CFloat TimeRemaining
		{
			get => GetProperty(ref _timeRemaining);
			set => SetProperty(ref _timeRemaining, value);
		}

		public gameuiBuffInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
