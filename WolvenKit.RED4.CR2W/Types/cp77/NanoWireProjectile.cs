using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NanoWireProjectile : BaseProjectile
	{
		private CFloat _maxAttackRange;
		private CEnum<ELaunchMode> _launchMode;

		[Ordinal(51)] 
		[RED("maxAttackRange")] 
		public CFloat MaxAttackRange
		{
			get => GetProperty(ref _maxAttackRange);
			set => SetProperty(ref _maxAttackRange, value);
		}

		[Ordinal(52)] 
		[RED("launchMode")] 
		public CEnum<ELaunchMode> LaunchMode
		{
			get => GetProperty(ref _launchMode);
			set => SetProperty(ref _launchMode, value);
		}

		public NanoWireProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
