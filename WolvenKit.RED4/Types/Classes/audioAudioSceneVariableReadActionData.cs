using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioSceneVariableReadActionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("comparer")] 
		public CEnum<audioNumberComparer> Comparer
		{
			get => GetPropertyValue<CEnum<audioNumberComparer>>();
			set => SetPropertyValue<CEnum<audioNumberComparer>>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public audioAudioSceneVariableReadActionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
