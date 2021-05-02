using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioBulletImpactSettings : audioEntitySettings
	{
		private CName _lowImpactSound;
		private CName _medImpactSound;
		private CName _hiImpactSound;
		private CName _critImpactSound;
		private CName _npcImpactSound;
		private CFloat _mediumDamageDistance;
		private CFloat _highDamageDistance;

		[Ordinal(6)] 
		[RED("lowImpactSound")] 
		public CName LowImpactSound
		{
			get => GetProperty(ref _lowImpactSound);
			set => SetProperty(ref _lowImpactSound, value);
		}

		[Ordinal(7)] 
		[RED("medImpactSound")] 
		public CName MedImpactSound
		{
			get => GetProperty(ref _medImpactSound);
			set => SetProperty(ref _medImpactSound, value);
		}

		[Ordinal(8)] 
		[RED("hiImpactSound")] 
		public CName HiImpactSound
		{
			get => GetProperty(ref _hiImpactSound);
			set => SetProperty(ref _hiImpactSound, value);
		}

		[Ordinal(9)] 
		[RED("critImpactSound")] 
		public CName CritImpactSound
		{
			get => GetProperty(ref _critImpactSound);
			set => SetProperty(ref _critImpactSound, value);
		}

		[Ordinal(10)] 
		[RED("npcImpactSound")] 
		public CName NpcImpactSound
		{
			get => GetProperty(ref _npcImpactSound);
			set => SetProperty(ref _npcImpactSound, value);
		}

		[Ordinal(11)] 
		[RED("mediumDamageDistance")] 
		public CFloat MediumDamageDistance
		{
			get => GetProperty(ref _mediumDamageDistance);
			set => SetProperty(ref _mediumDamageDistance, value);
		}

		[Ordinal(12)] 
		[RED("highDamageDistance")] 
		public CFloat HighDamageDistance
		{
			get => GetProperty(ref _highDamageDistance);
			set => SetProperty(ref _highDamageDistance, value);
		}

		public audioBulletImpactSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
