using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StimIdentificationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sourceID")] 
		public entEntityID SourceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		[Ordinal(2)] 
		[RED("stimName")] 
		public CName StimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public StimIdentificationData()
		{
			SourceID = new entEntityID();
			DelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
