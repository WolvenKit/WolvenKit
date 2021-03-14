using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTutorialOverlayInputRequest : redEvent
	{
		private CBool _isInputRequested;

		[Ordinal(0)] 
		[RED("isInputRequested")] 
		public CBool IsInputRequested
		{
			get
			{
				if (_isInputRequested == null)
				{
					_isInputRequested = (CBool) CR2WTypeManager.Create("Bool", "isInputRequested", cr2w, this);
				}
				return _isInputRequested;
			}
			set
			{
				if (_isInputRequested == value)
				{
					return;
				}
				_isInputRequested = value;
				PropertySet(this);
			}
		}

		public inkTutorialOverlayInputRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
