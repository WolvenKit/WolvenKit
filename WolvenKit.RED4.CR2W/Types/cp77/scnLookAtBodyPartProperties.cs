using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtBodyPartProperties : CVariable
	{
		private CFloat _enableFactor;
		private CFloat _override;
		private CInt32 _mode;

		[Ordinal(0)] 
		[RED("enableFactor")] 
		public CFloat EnableFactor
		{
			get => GetProperty(ref _enableFactor);
			set => SetProperty(ref _enableFactor, value);
		}

		[Ordinal(1)] 
		[RED("override")] 
		public CFloat Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		public scnLookAtBodyPartProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
