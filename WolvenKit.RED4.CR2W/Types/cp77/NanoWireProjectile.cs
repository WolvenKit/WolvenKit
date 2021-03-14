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
			get
			{
				if (_maxAttackRange == null)
				{
					_maxAttackRange = (CFloat) CR2WTypeManager.Create("Float", "maxAttackRange", cr2w, this);
				}
				return _maxAttackRange;
			}
			set
			{
				if (_maxAttackRange == value)
				{
					return;
				}
				_maxAttackRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("launchMode")] 
		public CEnum<ELaunchMode> LaunchMode
		{
			get
			{
				if (_launchMode == null)
				{
					_launchMode = (CEnum<ELaunchMode>) CR2WTypeManager.Create("ELaunchMode", "launchMode", cr2w, this);
				}
				return _launchMode;
			}
			set
			{
				if (_launchMode == value)
				{
					return;
				}
				_launchMode = value;
				PropertySet(this);
			}
		}

		public NanoWireProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
