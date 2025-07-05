using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetControllerLightColorRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("red")] 
		public CUInt8 Red
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("green")] 
		public CUInt8 Green
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("blue")] 
		public CUInt8 Blue
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("notQuest")] 
		public CBool NotQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetControllerLightColorRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
