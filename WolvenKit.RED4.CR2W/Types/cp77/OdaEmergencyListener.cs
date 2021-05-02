using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OdaEmergencyListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<NPCPuppet> _owner;
		private CInt32 _healNumber;
		private CFloat _heal1HealthPercentage;
		private CFloat _heal2HealthPercentage;
		private CFloat _heal3HealthPercentage;
		private CFloat _heal4HealthPercentage;
		private CFloat _heal5HealthPercentage;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("healNumber")] 
		public CInt32 HealNumber
		{
			get => GetProperty(ref _healNumber);
			set => SetProperty(ref _healNumber, value);
		}

		[Ordinal(2)] 
		[RED("heal1HealthPercentage")] 
		public CFloat Heal1HealthPercentage
		{
			get => GetProperty(ref _heal1HealthPercentage);
			set => SetProperty(ref _heal1HealthPercentage, value);
		}

		[Ordinal(3)] 
		[RED("heal2HealthPercentage")] 
		public CFloat Heal2HealthPercentage
		{
			get => GetProperty(ref _heal2HealthPercentage);
			set => SetProperty(ref _heal2HealthPercentage, value);
		}

		[Ordinal(4)] 
		[RED("heal3HealthPercentage")] 
		public CFloat Heal3HealthPercentage
		{
			get => GetProperty(ref _heal3HealthPercentage);
			set => SetProperty(ref _heal3HealthPercentage, value);
		}

		[Ordinal(5)] 
		[RED("heal4HealthPercentage")] 
		public CFloat Heal4HealthPercentage
		{
			get => GetProperty(ref _heal4HealthPercentage);
			set => SetProperty(ref _heal4HealthPercentage, value);
		}

		[Ordinal(6)] 
		[RED("heal5HealthPercentage")] 
		public CFloat Heal5HealthPercentage
		{
			get => GetProperty(ref _heal5HealthPercentage);
			set => SetProperty(ref _heal5HealthPercentage, value);
		}

		public OdaEmergencyListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
