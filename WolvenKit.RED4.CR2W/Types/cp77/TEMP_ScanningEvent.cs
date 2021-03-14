using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TEMP_ScanningEvent : redEvent
	{
		private CName _clue;
		private CBool _showUI;

		[Ordinal(0)] 
		[RED("clue")] 
		public CName Clue
		{
			get
			{
				if (_clue == null)
				{
					_clue = (CName) CR2WTypeManager.Create("CName", "clue", cr2w, this);
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
		[RED("showUI")] 
		public CBool ShowUI
		{
			get
			{
				if (_showUI == null)
				{
					_showUI = (CBool) CR2WTypeManager.Create("Bool", "showUI", cr2w, this);
				}
				return _showUI;
			}
			set
			{
				if (_showUI == value)
				{
					return;
				}
				_showUI = value;
				PropertySet(this);
			}
		}

		public TEMP_ScanningEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
