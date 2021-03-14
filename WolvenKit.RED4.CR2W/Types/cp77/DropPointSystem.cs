using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointSystem : gameScriptableSystem
	{
		private CArray<CHandle<DropPointPackage>> _packages;
		private CArray<CHandle<DropPointMappinRegistrationData>> _mappins;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("packages")] 
		public CArray<CHandle<DropPointPackage>> Packages
		{
			get
			{
				if (_packages == null)
				{
					_packages = (CArray<CHandle<DropPointPackage>>) CR2WTypeManager.Create("array:handle:DropPointPackage", "packages", cr2w, this);
				}
				return _packages;
			}
			set
			{
				if (_packages == value)
				{
					return;
				}
				_packages = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mappins")] 
		public CArray<CHandle<DropPointMappinRegistrationData>> Mappins
		{
			get
			{
				if (_mappins == null)
				{
					_mappins = (CArray<CHandle<DropPointMappinRegistrationData>>) CR2WTypeManager.Create("array:handle:DropPointMappinRegistrationData", "mappins", cr2w, this);
				}
				return _mappins;
			}
			set
			{
				if (_mappins == value)
				{
					return;
				}
				_mappins = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public DropPointSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
