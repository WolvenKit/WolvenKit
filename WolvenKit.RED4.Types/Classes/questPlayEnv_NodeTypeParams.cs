using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPlayEnv_NodeTypeParams : RedBaseClass
	{
		private CBool _enable;
		private CResourceReference<worldEnvironmentAreaParameters> _envParams;
		private CFloat _blendTime;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("envParams")] 
		public CResourceReference<worldEnvironmentAreaParameters> EnvParams
		{
			get => GetProperty(ref _envParams);
			set => SetProperty(ref _envParams, value);
		}

		[Ordinal(2)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		public questPlayEnv_NodeTypeParams()
		{
			_enable = true;
		}
	}
}
