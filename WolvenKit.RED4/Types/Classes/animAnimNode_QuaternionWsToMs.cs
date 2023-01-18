using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_QuaternionWsToMs : animAnimNode_QuaternionValue
	{
		[Ordinal(11)] 
		[RED("quaternionWs")] 
		public animQuaternionLink QuaternionWs
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		public animAnimNode_QuaternionWsToMs()
		{
			Id = 4294967295;
			QuaternionWs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
