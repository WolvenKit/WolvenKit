using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotCardData : CVariable
	{
		private CBool _empty;
		private CInt32 _index;
		private CName _imagePath;
		private CString _label;
		private CString _desc;

		[Ordinal(0)] 
		[RED("empty")] 
		public CBool Empty
		{
			get
			{
				if (_empty == null)
				{
					_empty = (CBool) CR2WTypeManager.Create("Bool", "empty", cr2w, this);
				}
				return _empty;
			}
			set
			{
				if (_empty == value)
				{
					return;
				}
				_empty = value;
				PropertySet(this);
			}
		}

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
		[RED("imagePath")] 
		public CName ImagePath
		{
			get
			{
				if (_imagePath == null)
				{
					_imagePath = (CName) CR2WTypeManager.Create("CName", "imagePath", cr2w, this);
				}
				return _imagePath;
			}
			set
			{
				if (_imagePath == value)
				{
					return;
				}
				_imagePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("label")] 
		public CString Label
		{
			get
			{
				if (_label == null)
				{
					_label = (CString) CR2WTypeManager.Create("String", "label", cr2w, this);
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

		[Ordinal(4)] 
		[RED("desc")] 
		public CString Desc
		{
			get
			{
				if (_desc == null)
				{
					_desc = (CString) CR2WTypeManager.Create("String", "desc", cr2w, this);
				}
				return _desc;
			}
			set
			{
				if (_desc == value)
				{
					return;
				}
				_desc = value;
				PropertySet(this);
			}
		}

		public TarotCardData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
