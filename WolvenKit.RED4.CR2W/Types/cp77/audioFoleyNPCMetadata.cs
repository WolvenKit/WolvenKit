using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFoleyNPCMetadata : audioAudioMetadata
	{
		private audioMeleeSound _fastHeavy;
		private audioMeleeSound _fastMedium;
		private audioMeleeSound _fastLight;
		private audioMeleeSound _normalHeavy;
		private audioMeleeSound _normalMedium;
		private audioMeleeSound _normalLight;
		private audioMeleeSound _slowHeavy;
		private audioMeleeSound _slowMedium;
		private audioMeleeSound _slowLight;
		private audioMeleeSound _walk;
		private audioMeleeSound _run;

		[Ordinal(1)] 
		[RED("fastHeavy")] 
		public audioMeleeSound FastHeavy
		{
			get => GetProperty(ref _fastHeavy);
			set => SetProperty(ref _fastHeavy, value);
		}

		[Ordinal(2)] 
		[RED("fastMedium")] 
		public audioMeleeSound FastMedium
		{
			get => GetProperty(ref _fastMedium);
			set => SetProperty(ref _fastMedium, value);
		}

		[Ordinal(3)] 
		[RED("fastLight")] 
		public audioMeleeSound FastLight
		{
			get => GetProperty(ref _fastLight);
			set => SetProperty(ref _fastLight, value);
		}

		[Ordinal(4)] 
		[RED("normalHeavy")] 
		public audioMeleeSound NormalHeavy
		{
			get => GetProperty(ref _normalHeavy);
			set => SetProperty(ref _normalHeavy, value);
		}

		[Ordinal(5)] 
		[RED("normalMedium")] 
		public audioMeleeSound NormalMedium
		{
			get => GetProperty(ref _normalMedium);
			set => SetProperty(ref _normalMedium, value);
		}

		[Ordinal(6)] 
		[RED("normalLight")] 
		public audioMeleeSound NormalLight
		{
			get => GetProperty(ref _normalLight);
			set => SetProperty(ref _normalLight, value);
		}

		[Ordinal(7)] 
		[RED("slowHeavy")] 
		public audioMeleeSound SlowHeavy
		{
			get => GetProperty(ref _slowHeavy);
			set => SetProperty(ref _slowHeavy, value);
		}

		[Ordinal(8)] 
		[RED("slowMedium")] 
		public audioMeleeSound SlowMedium
		{
			get => GetProperty(ref _slowMedium);
			set => SetProperty(ref _slowMedium, value);
		}

		[Ordinal(9)] 
		[RED("slowLight")] 
		public audioMeleeSound SlowLight
		{
			get => GetProperty(ref _slowLight);
			set => SetProperty(ref _slowLight, value);
		}

		[Ordinal(10)] 
		[RED("walk")] 
		public audioMeleeSound Walk
		{
			get => GetProperty(ref _walk);
			set => SetProperty(ref _walk, value);
		}

		[Ordinal(11)] 
		[RED("run")] 
		public audioMeleeSound Run
		{
			get => GetProperty(ref _run);
			set => SetProperty(ref _run, value);
		}

		public audioFoleyNPCMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
