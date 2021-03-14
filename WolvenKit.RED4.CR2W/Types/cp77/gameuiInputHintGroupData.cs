using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintGroupData : CVariable
	{
		private TweakDBID _iconReference;
		private CString _localizedTitle;
		private CString _localizedDescription;
		private CInt32 _sortingPriority;

		[Ordinal(0)] 
		[RED("iconReference")] 
		public TweakDBID IconReference
		{
			get
			{
				if (_iconReference == null)
				{
					_iconReference = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "iconReference", cr2w, this);
				}
				return _iconReference;
			}
			set
			{
				if (_iconReference == value)
				{
					return;
				}
				_iconReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("localizedTitle")] 
		public CString LocalizedTitle
		{
			get
			{
				if (_localizedTitle == null)
				{
					_localizedTitle = (CString) CR2WTypeManager.Create("String", "localizedTitle", cr2w, this);
				}
				return _localizedTitle;
			}
			set
			{
				if (_localizedTitle == value)
				{
					return;
				}
				_localizedTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localizedDescription")] 
		public CString LocalizedDescription
		{
			get
			{
				if (_localizedDescription == null)
				{
					_localizedDescription = (CString) CR2WTypeManager.Create("String", "localizedDescription", cr2w, this);
				}
				return _localizedDescription;
			}
			set
			{
				if (_localizedDescription == value)
				{
					return;
				}
				_localizedDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sortingPriority")] 
		public CInt32 SortingPriority
		{
			get
			{
				if (_sortingPriority == null)
				{
					_sortingPriority = (CInt32) CR2WTypeManager.Create("Int32", "sortingPriority", cr2w, this);
				}
				return _sortingPriority;
			}
			set
			{
				if (_sortingPriority == value)
				{
					return;
				}
				_sortingPriority = value;
				PropertySet(this);
			}
		}

		public gameuiInputHintGroupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
