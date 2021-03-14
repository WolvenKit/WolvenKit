using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TCSInputXYAxisEvent : redEvent
	{
		private CBool _isAnyInput;

		[Ordinal(0)] 
		[RED("isAnyInput")] 
		public CBool IsAnyInput
		{
			get
			{
				if (_isAnyInput == null)
				{
					_isAnyInput = (CBool) CR2WTypeManager.Create("Bool", "isAnyInput", cr2w, this);
				}
				return _isAnyInput;
			}
			set
			{
				if (_isAnyInput == value)
				{
					return;
				}
				_isAnyInput = value;
				PropertySet(this);
			}
		}

		public TCSInputXYAxisEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
