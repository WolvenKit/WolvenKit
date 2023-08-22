using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class inkanimEvent : IScriptable
	{
		[Ordinal(0)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkanimEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
