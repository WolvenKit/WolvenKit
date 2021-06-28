using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetGlobalTvChannel : redEvent
	{
		private TweakDBID _channel;

		[Ordinal(0)] 
		[RED("channel")] 
		public TweakDBID Channel
		{
			get => GetProperty(ref _channel);
			set => SetProperty(ref _channel, value);
		}

		public SetGlobalTvChannel(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
