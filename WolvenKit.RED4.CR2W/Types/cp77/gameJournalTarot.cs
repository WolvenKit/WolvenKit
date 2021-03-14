using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalTarot : gameJournalEntry
	{
		private CInt32 _index;
		private LocalizationString _name;
		private LocalizationString _description;
		private CName _imagePart;

		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("name")] 
		public LocalizationString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("description")] 
		public LocalizationString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get
			{
				if (_imagePart == null)
				{
					_imagePart = (CName) CR2WTypeManager.Create("CName", "imagePart", cr2w, this);
				}
				return _imagePart;
			}
			set
			{
				if (_imagePart == value)
				{
					return;
				}
				_imagePart = value;
				PropertySet(this);
			}
		}

		public gameJournalTarot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
