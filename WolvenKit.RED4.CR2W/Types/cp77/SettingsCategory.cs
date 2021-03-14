using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsCategory : CVariable
	{
		private CName _label;
		private CArray<SettingsCategory> _subcategories;
		private CArray<CHandle<userSettingsVar>> _options;
		private CBool _isEmpty;
		private CName _groupPath;

		[Ordinal(0)] 
		[RED("label")] 
		public CName Label
		{
			get
			{
				if (_label == null)
				{
					_label = (CName) CR2WTypeManager.Create("CName", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("subcategories")] 
		public CArray<SettingsCategory> Subcategories
		{
			get
			{
				if (_subcategories == null)
				{
					_subcategories = (CArray<SettingsCategory>) CR2WTypeManager.Create("array:SettingsCategory", "subcategories", cr2w, this);
				}
				return _subcategories;
			}
			set
			{
				if (_subcategories == value)
				{
					return;
				}
				_subcategories = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("options")] 
		public CArray<CHandle<userSettingsVar>> Options
		{
			get
			{
				if (_options == null)
				{
					_options = (CArray<CHandle<userSettingsVar>>) CR2WTypeManager.Create("array:handle:userSettingsVar", "options", cr2w, this);
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

		[Ordinal(3)] 
		[RED("isEmpty")] 
		public CBool IsEmpty
		{
			get
			{
				if (_isEmpty == null)
				{
					_isEmpty = (CBool) CR2WTypeManager.Create("Bool", "isEmpty", cr2w, this);
				}
				return _isEmpty;
			}
			set
			{
				if (_isEmpty == value)
				{
					return;
				}
				_isEmpty = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get
			{
				if (_groupPath == null)
				{
					_groupPath = (CName) CR2WTypeManager.Create("CName", "groupPath", cr2w, this);
				}
				return _groupPath;
			}
			set
			{
				if (_groupPath == value)
				{
					return;
				}
				_groupPath = value;
				PropertySet(this);
			}
		}

		public SettingsCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
