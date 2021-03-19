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
			get => GetProperty(ref _processing);
			set => SetProperty(ref _processing, value);
		}

		[Ordinal(3)] 
		[RED("gunFalls")] 
		public CName GunFalls
		{
			get => GetProperty(ref _gunFalls);
			set => SetProperty(ref _gunFalls, value);
		}

		public WeaponVendingMachineSFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
