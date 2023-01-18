using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IgnoreBarbedWirePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("minStateTime")] 
		public CFloat MinStateTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IgnoreBarbedWirePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
