using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVendorPanelData : IScriptable
	{
		private gameVendorData _data;
		private CString _assetsLibrary;
		private CName _rootItemName;

		[Ordinal(0)] 
		[RED("data")] 
		public gameVendorData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (gameVendorData) CR2WTypeManager.Create("gameVendorData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("assetsLibrary")] 
		public CString AssetsLibrary
		{
			get
			{
				if (_assetsLibrary == null)
				{
					_assetsLibrary = (CString) CR2WTypeManager.Create("String", "assetsLibrary", cr2w, this);
				}
				return _assetsLibrary;
			}
			set
			{
				if (_assetsLibrary == value)
				{
					return;
				}
				_assetsLibrary = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rootItemName")] 
		public CName RootItemName
		{
			get
			{
				if (_rootItemName == null)
				{
					_rootItemName = (CName) CR2WTypeManager.Create("CName", "rootItemName", cr2w, this);
				}
				return _rootItemName;
			}
			set
			{
				if (_rootItemName == value)
				{
					return;
				}
				_rootItemName = value;
				PropertySet(this);
			}
		}

		public questVendorPanelData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
