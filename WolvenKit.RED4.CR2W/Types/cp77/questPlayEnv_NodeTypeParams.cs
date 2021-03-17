using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayEnv_NodeTypeParams : CVariable
	{
		private CBool _enable;
		private rRef<worldEnvironmentAreaParameters> _envParams;
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
		public rRef<worldEnvironmentAreaParameters> EnvParams
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

		public questPlayEnv_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
