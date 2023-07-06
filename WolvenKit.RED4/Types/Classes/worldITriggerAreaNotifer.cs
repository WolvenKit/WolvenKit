using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class worldITriggerAreaNotifer : IScriptable
	{
		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("includeChannels")] 
		public CBitField<TriggerChannel> IncludeChannels
		{
			get => GetPropertyValue<CBitField<TriggerChannel>>();
			set => SetPropertyValue<CBitField<TriggerChannel>>(value);
		}

		[Ordinal(2)] 
		[RED("excludeChannels")] 
		public CUInt32 ExcludeChannels
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldITriggerAreaNotifer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
