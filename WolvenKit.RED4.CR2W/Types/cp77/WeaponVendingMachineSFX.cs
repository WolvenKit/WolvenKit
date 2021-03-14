using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponVendingMachineSFX : VendingMachineSFX
	{
		private CName _processing;
		private CName _gunFalls;

		[Ordinal(2)] 
		[RED("processing")] 
		public CName Processing
		{
			get
			{
				if (_processing == null)
				{
					_processing = (CName) CR2WTypeManager.Create("CName", "processing", cr2w, this);
				}
				return _processing;
			}
			set
			{
				if (_processing == value)
				{
					return;
				}
				_processing = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gunFalls")] 
		public CName GunFalls
		{
			get
			{
				if (_gunFalls == null)
				{
					_gunFalls = (CName) CR2WTypeManager.Create("CName", "gunFalls", cr2w, this);
				}
				return _gunFalls;
			}
			set
			{
				if (_gunFalls == value)
				{
					return;
				}
				_gunFalls = value;
				PropertySet(this);
			}
		}

		public WeaponVendingMachineSFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
