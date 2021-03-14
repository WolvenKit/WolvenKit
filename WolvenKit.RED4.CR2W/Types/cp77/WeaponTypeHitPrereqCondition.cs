using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _type;

		[Ordinal(1)] 
		[RED("type")] 
		public CName Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CName) CR2WTypeManager.Create("CName", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public WeaponTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
