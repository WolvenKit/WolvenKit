using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWeakPoints : CVariable
	{
		private CName _weakPointName;
		private CString _loc_name_key;
		private CString _loc_desc_key;

		[Ordinal(0)] 
		[RED("weakPointName")] 
		public CName WeakPointName
		{
			get
			{
				if (_weakPointName == null)
				{
					_weakPointName = (CName) CR2WTypeManager.Create("CName", "weakPointName", cr2w, this);
				}
				return _weakPointName;
			}
			set
			{
				if (_weakPointName == value)
				{
					return;
				}
				_weakPointName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("loc_name_key")] 
		public CString Loc_name_key
		{
			get
			{
				if (_loc_name_key == null)
				{
					_loc_name_key = (CString) CR2WTypeManager.Create("String", "loc_name_key", cr2w, this);
				}
				return _loc_name_key;
			}
			set
			{
				if (_loc_name_key == value)
				{
					return;
				}
				_loc_name_key = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("loc_desc_key")] 
		public CString Loc_desc_key
		{
			get
			{
				if (_loc_desc_key == null)
				{
					_loc_desc_key = (CString) CR2WTypeManager.Create("String", "loc_desc_key", cr2w, this);
				}
				return _loc_desc_key;
			}
			set
			{
				if (_loc_desc_key == value)
				{
					return;
				}
				_loc_desc_key = value;
				PropertySet(this);
			}
		}

		public SWeakPoints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
