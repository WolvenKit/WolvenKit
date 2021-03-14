using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitFlagPrereq : GenericHitPrereq
	{
		private CEnum<hitFlag> _flag;

		[Ordinal(5)] 
		[RED("flag")] 
		public CEnum<hitFlag> Flag
		{
			get
			{
				if (_flag == null)
				{
					_flag = (CEnum<hitFlag>) CR2WTypeManager.Create("hitFlag", "flag", cr2w, this);
				}
				return _flag;
			}
			set
			{
				if (_flag == value)
				{
					return;
				}
				_flag = value;
				PropertySet(this);
			}
		}

		public HitFlagPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
