using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IceMachineSFX : VendingMachineSFX
	{
		private CName _iceFalls;
		private CName _processing;

		[Ordinal(2)] 
		[RED("iceFalls")] 
		public CName IceFalls
		{
			get => GetProperty(ref _iceFalls);
			set => SetProperty(ref _iceFalls, value);
		}

		[Ordinal(3)] 
		[RED("processing")] 
		public CName Processing
		{
			get => GetProperty(ref _processing);
			set => SetProperty(ref _processing, value);
		}

		public IceMachineSFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
