using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIPhoneConditionType : questIUIConditionType
	{
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		public questIPhoneConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
