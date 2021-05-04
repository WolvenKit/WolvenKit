using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTriggerActivatorComponent : entIPlacedComponent
	{
		private CFloat _radius;
		private CFloat _height;
		private CEnum<TriggerChannel> _channels;
		private CFloat _maxContinousDistance;
		private CBool _enableCCD;
		private CBool _isEnabled;

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(6)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(7)] 
		[RED("channels")] 
		public CEnum<TriggerChannel> Channels
		{
			get => GetProperty(ref _channels);
			set => SetProperty(ref _channels, value);
		}

		[Ordinal(8)] 
		[RED("maxContinousDistance")] 
		public CFloat MaxContinousDistance
		{
			get => GetProperty(ref _maxContinousDistance);
			set => SetProperty(ref _maxContinousDistance, value);
		}

		[Ordinal(9)] 
		[RED("enableCCD")] 
		public CBool EnableCCD
		{
			get => GetProperty(ref _enableCCD);
			set => SetProperty(ref _enableCCD, value);
		}

		[Ordinal(10)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public entTriggerActivatorComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
