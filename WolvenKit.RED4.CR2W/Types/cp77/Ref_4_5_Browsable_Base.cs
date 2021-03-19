using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_5_Browsable_Base : CVariable
	{
		private CInt32 _firstBaseVar;
		private CInt32 _secondBaseVar;
		private CInt32 _thirdBaseVar;

		[Ordinal(0)] 
		[RED("firstBaseVar")] 
		public CInt32 FirstBaseVar
		{
			get => GetProperty(ref _firstBaseVar);
			set => SetProperty(ref _firstBaseVar, value);
		}

		[Ordinal(1)] 
		[RED("secondBaseVar")] 
		public CInt32 SecondBaseVar
		{
			get => GetProperty(ref _secondBaseVar);
			set => SetProperty(ref _secondBaseVar, value);
		}

		[Ordinal(2)] 
		[RED("thirdBaseVar")] 
		public CInt32 ThirdBaseVar
		{
			get => GetProperty(ref _thirdBaseVar);
			set => SetProperty(ref _thirdBaseVar, value);
		}

		public Ref_4_5_Browsable_Base(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
