using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopRTTIClassDump : CVariable
	{
		private CArray<CString> _classNames;
		private CArray<CString> _descriptiveNames;
		private CArray<interopRTTIResourceDumpInfo> _resourceInfos;
		private CArray<interopRTTIClassDumpEntry> _entries;

		[Ordinal(0)] 
		[RED("classNames")] 
		public CArray<CString> ClassNames
		{
			get
			{
				if (_classNames == null)
				{
					_classNames = (CArray<CString>) CR2WTypeManager.Create("array:String", "classNames", cr2w, this);
				}
				return _classNames;
			}
			set
			{
				if (_classNames == value)
				{
					return;
				}
				_classNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("descriptiveNames")] 
		public CArray<CString> DescriptiveNames
		{
			get
			{
				if (_descriptiveNames == null)
				{
					_descriptiveNames = (CArray<CString>) CR2WTypeManager.Create("array:String", "descriptiveNames", cr2w, this);
				}
				return _descriptiveNames;
			}
			set
			{
				if (_descriptiveNames == value)
				{
					return;
				}
				_descriptiveNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("resourceInfos")] 
		public CArray<interopRTTIResourceDumpInfo> ResourceInfos
		{
			get
			{
				if (_resourceInfos == null)
				{
					_resourceInfos = (CArray<interopRTTIResourceDumpInfo>) CR2WTypeManager.Create("array:interopRTTIResourceDumpInfo", "resourceInfos", cr2w, this);
				}
				return _resourceInfos;
			}
			set
			{
				if (_resourceInfos == value)
				{
					return;
				}
				_resourceInfos = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<interopRTTIClassDumpEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<interopRTTIClassDumpEntry>) CR2WTypeManager.Create("array:interopRTTIClassDumpEntry", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		public interopRTTIClassDump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
