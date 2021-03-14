using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayStore : CVariable
	{
		private CArray<scnscreenplayDialogLine> _lines;
		private CArray<scnscreenplayChoiceOption> _options;

		[Ordinal(0)] 
		[RED("lines")] 
		public CArray<scnscreenplayDialogLine> Lines
		{
			get
			{
				if (_lines == null)
				{
					_lines = (CArray<scnscreenplayDialogLine>) CR2WTypeManager.Create("array:scnscreenplayDialogLine", "lines", cr2w, this);
				}
				return _lines;
			}
			set
			{
				if (_lines == value)
				{
					return;
				}
				_lines = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("options")] 
		public CArray<scnscreenplayChoiceOption> Options
		{
			get
			{
				if (_options == null)
				{
					_options = (CArray<scnscreenplayChoiceOption>) CR2WTypeManager.Create("array:scnscreenplayChoiceOption", "options", cr2w, this);
				}
				return _options;
			}
			set
			{
				if (_options == value)
				{
					return;
				}
				_options = value;
				PropertySet(this);
			}
		}

		public scnscreenplayStore(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
