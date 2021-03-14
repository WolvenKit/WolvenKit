using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalMetaQuestScriptedData : CVariable
	{
		private CUInt32 _percent;
		private CBool _hidden;
		private CString _text;

		[Ordinal(0)] 
		[RED("percent")] 
		public CUInt32 Percent
		{
			get
			{
				if (_percent == null)
				{
					_percent = (CUInt32) CR2WTypeManager.Create("Uint32", "percent", cr2w, this);
				}
				return _percent;
			}
			set
			{
				if (_percent == value)
				{
					return;
				}
				_percent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hidden")] 
		public CBool Hidden
		{
			get
			{
				if (_hidden == null)
				{
					_hidden = (CBool) CR2WTypeManager.Create("Bool", "hidden", cr2w, this);
				}
				return _hidden;
			}
			set
			{
				if (_hidden == value)
				{
					return;
				}
				_hidden = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		public gameJournalMetaQuestScriptedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
