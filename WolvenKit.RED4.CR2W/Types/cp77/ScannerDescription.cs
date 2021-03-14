using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerDescription : ScannerChunk
	{
		private CString _defaultFluffDescription;
		private CArray<CString> _customDescriptions;

		[Ordinal(0)] 
		[RED("defaultFluffDescription")] 
		public CString DefaultFluffDescription
		{
			get
			{
				if (_defaultFluffDescription == null)
				{
					_defaultFluffDescription = (CString) CR2WTypeManager.Create("String", "defaultFluffDescription", cr2w, this);
				}
				return _defaultFluffDescription;
			}
			set
			{
				if (_defaultFluffDescription == value)
				{
					return;
				}
				_defaultFluffDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("customDescriptions")] 
		public CArray<CString> CustomDescriptions
		{
			get
			{
				if (_customDescriptions == null)
				{
					_customDescriptions = (CArray<CString>) CR2WTypeManager.Create("array:String", "customDescriptions", cr2w, this);
				}
				return _customDescriptions;
			}
			set
			{
				if (_customDescriptions == value)
				{
					return;
				}
				_customDescriptions = value;
				PropertySet(this);
			}
		}

		public ScannerDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
