using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetBase : IScriptable
	{
		private CName _name;
		private CString _linkAddress;
		private CColor _tintColor;
		private CColor _hoverTintColor;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
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

		[Ordinal(1)] 
		[RED("linkAddress")] 
		public CString LinkAddress
		{
			get
			{
				if (_linkAddress == null)
				{
					_linkAddress = (CString) CR2WTypeManager.Create("String", "linkAddress", cr2w, this);
				}
				return _linkAddress;
			}
			set
			{
				if (_linkAddress == value)
				{
					return;
				}
				_linkAddress = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tintColor")] 
		public CColor TintColor
		{
			get
			{
				if (_tintColor == null)
				{
					_tintColor = (CColor) CR2WTypeManager.Create("Color", "tintColor", cr2w, this);
				}
				return _tintColor;
			}
			set
			{
				if (_tintColor == value)
				{
					return;
				}
				_tintColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hoverTintColor")] 
		public CColor HoverTintColor
		{
			get
			{
				if (_hoverTintColor == null)
				{
					_hoverTintColor = (CColor) CR2WTypeManager.Create("Color", "hoverTintColor", cr2w, this);
				}
				return _hoverTintColor;
			}
			set
			{
				if (_hoverTintColor == value)
				{
					return;
				}
				_hoverTintColor = value;
				PropertySet(this);
			}
		}

		public gameJournalInternetBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
