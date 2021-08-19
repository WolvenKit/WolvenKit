using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWaitingSignLayerDefinition : inkLayerDefinition
	{
		private CName _introAnimName;
		private CName _waitingAnimName;
		private CName _outroAnimName;
		private CFloat _delayTime;
		private CFloat _introTime;
		private CFloat _waitingTime;
		private CFloat _postWaitTime;
		private CFloat _outroTime;
		private CFloat _layerInitTime;

		[Ordinal(8)] 
		[RED("introAnimName")] 
		public CName IntroAnimName
		{
			get => GetProperty(ref _introAnimName);
			set => SetProperty(ref _introAnimName, value);
		}

		[Ordinal(9)] 
		[RED("waitingAnimName")] 
		public CName WaitingAnimName
		{
			get => GetProperty(ref _waitingAnimName);
			set => SetProperty(ref _waitingAnimName, value);
		}

		[Ordinal(10)] 
		[RED("outroAnimName")] 
		public CName OutroAnimName
		{
			get => GetProperty(ref _outroAnimName);
			set => SetProperty(ref _outroAnimName, value);
		}

		[Ordinal(11)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetProperty(ref _delayTime);
			set => SetProperty(ref _delayTime, value);
		}

		[Ordinal(12)] 
		[RED("introTime")] 
		public CFloat IntroTime
		{
			get => GetProperty(ref _introTime);
			set => SetProperty(ref _introTime, value);
		}

		[Ordinal(13)] 
		[RED("waitingTime")] 
		public CFloat WaitingTime
		{
			get => GetProperty(ref _waitingTime);
			set => SetProperty(ref _waitingTime, value);
		}

		[Ordinal(14)] 
		[RED("postWaitTime")] 
		public CFloat PostWaitTime
		{
			get => GetProperty(ref _postWaitTime);
			set => SetProperty(ref _postWaitTime, value);
		}

		[Ordinal(15)] 
		[RED("outroTime")] 
		public CFloat OutroTime
		{
			get => GetProperty(ref _outroTime);
			set => SetProperty(ref _outroTime, value);
		}

		[Ordinal(16)] 
		[RED("layerInitTime")] 
		public CFloat LayerInitTime
		{
			get => GetProperty(ref _layerInitTime);
			set => SetProperty(ref _layerInitTime, value);
		}

		public inkWaitingSignLayerDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
