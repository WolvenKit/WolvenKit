using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerQuickhackData : CVariable
	{
		private TweakDBID _actionTweak;
		private CFloat _actionPenetration;
		private CInt32 _quality;

		[Ordinal(0)] 
		[RED("actionTweak")] 
		public TweakDBID ActionTweak
		{
			get => GetProperty(ref _actionTweak);
			set => SetProperty(ref _actionTweak, value);
		}

		[Ordinal(1)] 
		[RED("actionPenetration")] 
		public CFloat ActionPenetration
		{
			get => GetProperty(ref _actionPenetration);
			set => SetProperty(ref _actionPenetration, value);
		}

		[Ordinal(2)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		public PlayerQuickhackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
