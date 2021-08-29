using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EmitterGroupAreaParams : RedBaseClass
	{
		private CEnum<EEmitterGroup> _group;
		private CLegacySingleChannelCurve<CFloat> _emissionScale;
		private CLegacySingleChannelCurve<CFloat> _opacityScale;

		[Ordinal(0)] 
		[RED("group")] 
		public CEnum<EEmitterGroup> Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(1)] 
		[RED("emissionScale")] 
		public CLegacySingleChannelCurve<CFloat> EmissionScale
		{
			get => GetProperty(ref _emissionScale);
			set => SetProperty(ref _emissionScale, value);
		}

		[Ordinal(2)] 
		[RED("opacityScale")] 
		public CLegacySingleChannelCurve<CFloat> OpacityScale
		{
			get => GetProperty(ref _opacityScale);
			set => SetProperty(ref _opacityScale, value);
		}
	}
}
