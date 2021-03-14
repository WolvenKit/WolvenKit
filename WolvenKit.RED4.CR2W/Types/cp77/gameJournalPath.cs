using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalPath : IScriptable
	{
		private CString _realPath;
		private CInt32 _fileEntryIndex;
		private CName _className;

		[Ordinal(0)] 
		[RED("realPath")] 
		public CString RealPath
		{
			get
			{
				if (_realPath == null)
				{
					_realPath = (CString) CR2WTypeManager.Create("String", "realPath", cr2w, this);
				}
				return _realPath;
			}
			set
			{
				if (_realPath == value)
				{
					return;
				}
				_realPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fileEntryIndex")] 
		public CInt32 FileEntryIndex
		{
			get
			{
				if (_fileEntryIndex == null)
				{
					_fileEntryIndex = (CInt32) CR2WTypeManager.Create("Int32", "fileEntryIndex", cr2w, this);
				}
				return _fileEntryIndex;
			}
			set
			{
				if (_fileEntryIndex == value)
				{
					return;
				}
				_fileEntryIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("className")] 
		public CName ClassName
		{
			get
			{
				if (_className == null)
				{
					_className = (CName) CR2WTypeManager.Create("CName", "className", cr2w, this);
				}
				return _className;
			}
			set
			{
				if (_className == value)
				{
					return;
				}
				_className = value;
				PropertySet(this);
			}
		}

		public gameJournalPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
