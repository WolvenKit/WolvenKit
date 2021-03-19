using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_WeightedQsTransform : ISerializable
	{
		private CHandle<animIAnimNodeSourceChannel_QsTransform> _channel;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("channel")] 
		public CHandle<animIAnimNodeSourceChannel_QsTransform> Channel
		{
			get => GetProperty(ref _channel);
			set => SetProperty(ref _channel, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		public animAnimNodeSourceChannel_WeightedQsTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
