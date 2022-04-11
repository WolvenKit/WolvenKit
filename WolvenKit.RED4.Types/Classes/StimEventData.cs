using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StimEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}
	}
}
