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
			get
			{
				if (_healthValueToSet == null)
				{
					_healthValueToSet = (CFloat) CR2WTypeManager.Create("Float", "healthValueToSet", cr2w, this);
				}
				return _healthValueToSet;
			}
			set
			{
				if (_healthValueToSet == value)
				{
					return;
				}
				_healthValueToSet = value;
				PropertySet(this);
			}
		}

		public SetTargetHealthEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
