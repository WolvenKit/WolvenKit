using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisableObjectDescriptionEvent : redEvent
	{
		private CBool _isDisabled;

		[Ordinal(0)] 
		[RED("isDisabled")] 
		public CBool IsDisabled
		{
			get
			{
				if (_isDisabled == null)
				{
					_isDisabled = (CBool) CR2WTypeManager.Create("Bool", "isDisabled", cr2w, this);
				}
				return _isDisabled;
			}
			set
			{
				if (_isDisabled == value)
				{
					return;
				}
				_isDisabled = value;
				PropertySet(this);
			}
		}

		public DisableObjectDescriptionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
