using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTargetHealthEffector : gameEffector
	{
		private CFloat _healthValueToSet;

		[Ordinal(0)] 
		[RED("healthValueToSet")] 
		public CFloat HealthValueToSet
		{
			get => GetProperty(ref _healthValueToSet);
			set => SetProperty(ref _healthValueToSet, value);
		}

		public SetTargetHealthEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
