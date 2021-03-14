using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerName : ScannerChunk
	{
		private CString _displayName;
		private CBool _hasArchetype;
		private CHandle<textTextParameterSet> _textParams;

		[Ordinal(0)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					_displayName = (CString) CR2WTypeManager.Create("String", "displayName", cr2w, this);
				}
				return _displayName;
			}
			set
			{
				if (_displayName == value)
				{
					return;
				}
				_displayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hasArchetype")] 
		public CBool HasArchetype
		{
			get
			{
				if (_hasArchetype == null)
				{
					_hasArchetype = (CBool) CR2WTypeManager.Create("Bool", "hasArchetype", cr2w, this);
				}
				return _hasArchetype;
			}
			set
			{
				if (_hasArchetype == value)
				{
					return;
				}
				_hasArchetype = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get
			{
				if (_textParams == null)
				{
					_textParams = (CHandle<textTextParameterSet>) CR2WTypeManager.Create("handle:textTextParameterSet", "textParams", cr2w, this);
				}
				return _textParams;
			}
			set
			{
				if (_textParams == value)
				{
					return;
				}
				_textParams = value;
				PropertySet(this);
			}
		}

		public ScannerName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
