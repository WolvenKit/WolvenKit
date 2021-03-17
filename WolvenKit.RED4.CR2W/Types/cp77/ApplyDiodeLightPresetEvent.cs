using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyDiodeLightPresetEvent : redEvent
	{
		private DiodeLightPreset _preset;
		private CFloat _delay;
		private CFloat _duration;
		private CBool _force;

		[Ordinal(0)] 
		[RED("preset")] 
		public DiodeLightPreset Preset
		{
			get => GetProperty(ref _preset);
			set => SetProperty(ref _preset, value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetProperty(ref _force);
			set => SetProperty(ref _force, value);
		}

		public ApplyDiodeLightPresetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
