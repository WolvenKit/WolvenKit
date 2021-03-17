using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerControlDeviceData : CVariable
	{
		private CFloat _currentYawModifier;
		private CFloat _currentPitchModifier;

		[Ordinal(0)] 
		[RED("currentYawModifier")] 
		public CFloat CurrentYawModifier
		{
			get => GetProperty(ref _currentYawModifier);
			set => SetProperty(ref _currentYawModifier, value);
		}

		[Ordinal(1)] 
		[RED("currentPitchModifier")] 
		public CFloat CurrentPitchModifier
		{
			get => GetProperty(ref _currentPitchModifier);
			set => SetProperty(ref _currentPitchModifier, value);
		}

		public PlayerControlDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
