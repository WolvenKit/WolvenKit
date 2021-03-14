using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreview_ReadyToBeDisplayed : redEvent
	{
		private CBool _isMale;

		[Ordinal(0)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get
			{
				if (_isMale == null)
				{
					_isMale = (CBool) CR2WTypeManager.Create("Bool", "isMale", cr2w, this);
				}
				return _isMale;
			}
			set
			{
				if (_isMale == value)
				{
					return;
				}
				_isMale = value;
				PropertySet(this);
			}
		}

		public gameuiPuppetPreview_ReadyToBeDisplayed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
