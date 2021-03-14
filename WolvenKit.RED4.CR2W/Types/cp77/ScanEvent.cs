using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScanEvent : redEvent
	{
		private CString _clue;
		private CBool _isAvailable;

		[Ordinal(0)] 
		[RED("clue")] 
		public CString Clue
		{
			get
			{
				if (_clue == null)
				{
					_clue = (CString) CR2WTypeManager.Create("String", "clue", cr2w, this);
				}
				return _clue;
			}
			set
			{
				if (_clue == value)
				{
					return;
				}
				_clue = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get
			{
				if (_isAvailable == null)
				{
					_isAvailable = (CBool) CR2WTypeManager.Create("Bool", "isAvailable", cr2w, this);
				}
				return _isAvailable;
			}
			set
			{
				if (_isAvailable == value)
				{
					return;
				}
				_isAvailable = value;
				PropertySet(this);
			}
		}

		public ScanEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
