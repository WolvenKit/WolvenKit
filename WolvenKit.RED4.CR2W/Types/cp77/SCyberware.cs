using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCyberware : CVariable
	{
		private CString _cyberwareName;
		private CInt32 _cyberWareTier;
		private CString _loc_name_key;
		private CString _loc_desc_key;

		[Ordinal(0)] 
		[RED("cyberwareName")] 
		public CString CyberwareName
		{
			get
			{
				if (_cyberwareName == null)
				{
					_cyberwareName = (CString) CR2WTypeManager.Create("String", "cyberwareName", cr2w, this);
				}
				return _cyberwareName;
			}
			set
			{
				if (_cyberwareName == value)
				{
					return;
				}
				_cyberwareName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cyberWareTier")] 
		public CInt32 CyberWareTier
		{
			get
			{
				if (_cyberWareTier == null)
				{
					_cyberWareTier = (CInt32) CR2WTypeManager.Create("Int32", "cyberWareTier", cr2w, this);
				}
				return _cyberWareTier;
			}
			set
			{
				if (_cyberWareTier == value)
				{
					return;
				}
				_cyberWareTier = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		public SCyberware(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
