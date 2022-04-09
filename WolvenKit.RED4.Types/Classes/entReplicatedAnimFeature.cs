using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReplicatedAnimFeature : entReplicatedItem
	{
		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CHandle<animAnimFeature> Value
		{
			get => GetPropertyValue<CHandle<animAnimFeature>>();
			set => SetPropertyValue<CHandle<animAnimFeature>>(value);
		}

		[Ordinal(4)] 
		[RED("invokeCallback")] 
		public CBool InvokeCallback
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entReplicatedAnimFeature()
		{
			InvokeCallback = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
