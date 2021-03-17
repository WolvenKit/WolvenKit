using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrossingLightSetup : CVariable
	{
		private CName _greenLightSFX;
		private CName _redLightSFX;

		[Ordinal(0)] 
		[RED("greenLightSFX")] 
		public CName GreenLightSFX
		{
			get => GetProperty(ref _greenLightSFX);
			set => SetProperty(ref _greenLightSFX, value);
		}

		[Ordinal(1)] 
		[RED("redLightSFX")] 
		public CName RedLightSFX
		{
			get => GetProperty(ref _redLightSFX);
			set => SetProperty(ref _redLightSFX, value);
		}

		public CrossingLightSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
