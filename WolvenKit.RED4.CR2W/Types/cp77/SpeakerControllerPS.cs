using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpeakerControllerPS : ScriptableDeviceComponentPS
	{
		private SpeakerSetup _speakerSetup;
		private CName _currentValue;
		private CName _previousValue;

		[Ordinal(104)] 
		[RED("speakerSetup")] 
		public SpeakerSetup SpeakerSetup
		{
			get => GetProperty(ref _speakerSetup);
			set => SetProperty(ref _speakerSetup, value);
		}

		[Ordinal(105)] 
		[RED("currentValue")] 
		public CName CurrentValue
		{
			get => GetProperty(ref _currentValue);
			set => SetProperty(ref _currentValue, value);
		}

		[Ordinal(106)] 
		[RED("previousValue")] 
		public CName PreviousValue
		{
			get => GetProperty(ref _previousValue);
			set => SetProperty(ref _previousValue, value);
		}

		public SpeakerControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
