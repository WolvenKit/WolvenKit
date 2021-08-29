using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSpotSequenceCategory : RedBaseClass
	{
		private CEnum<gamedataWorkspotCategory> _type;
		private CFloat _probability;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataWorkspotCategory> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}
	}
}
