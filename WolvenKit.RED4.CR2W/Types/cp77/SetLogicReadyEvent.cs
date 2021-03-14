using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetLogicReadyEvent : redEvent
	{
		private CBool _isReady;

		[Ordinal(0)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get
			{
				if (_isReady == null)
				{
					_isReady = (CBool) CR2WTypeManager.Create("Bool", "isReady", cr2w, this);
				}
				return _isReady;
			}
			set
			{
				if (_isReady == value)
				{
					return;
				}
				_isReady = value;
				PropertySet(this);
			}
		}

		public SetLogicReadyEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
