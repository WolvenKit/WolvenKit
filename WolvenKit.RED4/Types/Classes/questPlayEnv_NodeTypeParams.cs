using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlayEnv_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("envParams")] 
		public CResourceReference<worldEnvironmentAreaParameters> EnvParams
		{
			get => GetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>();
			set => SetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>(value);
		}

		[Ordinal(2)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questPlayEnv_NodeTypeParams()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
