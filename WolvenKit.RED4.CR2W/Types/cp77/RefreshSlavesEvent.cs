using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshSlavesEvent : redEvent
	{
		private CBool _onInitialize;

		[Ordinal(0)] 
		[RED("onInitialize")] 
		public CBool OnInitialize
		{
			get
			{
				if (_onInitialize == null)
				{
					_onInitialize = (CBool) CR2WTypeManager.Create("Bool", "onInitialize", cr2w, this);
				}
				return _onInitialize;
			}
			set
			{
				if (_onInitialize == value)
				{
					return;
				}
				_onInitialize = value;
				PropertySet(this);
			}
		}

		public RefreshSlavesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
