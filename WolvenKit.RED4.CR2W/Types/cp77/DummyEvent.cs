using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DummyEvent : redEvent
	{
		private CBool _disable;
		private CInt32 _ix;

		[Ordinal(0)] 
		[RED("disable")] 
		public CBool Disable
		{
			get
			{
				if (_disable == null)
				{
					_disable = (CBool) CR2WTypeManager.Create("Bool", "disable", cr2w, this);
				}
				return _disable;
			}
			set
			{
				if (_disable == value)
				{
					return;
				}
				_disable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ix")] 
		public CInt32 Ix
		{
			get
			{
				if (_ix == null)
				{
					_ix = (CInt32) CR2WTypeManager.Create("Int32", "ix", cr2w, this);
				}
				return _ix;
			}
			set
			{
				if (_ix == value)
				{
					return;
				}
				_ix = value;
				PropertySet(this);
			}
		}

		public DummyEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
