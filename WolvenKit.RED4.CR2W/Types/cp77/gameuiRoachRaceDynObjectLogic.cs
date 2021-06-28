using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceDynObjectLogic : gameuiSideScrollerMiniGameDynObjectLogic
	{
		private CFloat _minSpawnY;
		private CFloat _maxSpawnY;
		private CFloat _extraSpeed;
		private CArray<CFloat> _availableY;

		[Ordinal(2)] 
		[RED("minSpawnY")] 
		public CFloat MinSpawnY
		{
			get => GetProperty(ref _minSpawnY);
			set => SetProperty(ref _minSpawnY, value);
		}

		[Ordinal(3)] 
		[RED("maxSpawnY")] 
		public CFloat MaxSpawnY
		{
			get => GetProperty(ref _maxSpawnY);
			set => SetProperty(ref _maxSpawnY, value);
		}

		[Ordinal(4)] 
		[RED("extraSpeed")] 
		public CFloat ExtraSpeed
		{
			get => GetProperty(ref _extraSpeed);
			set => SetProperty(ref _extraSpeed, value);
		}

		[Ordinal(5)] 
		[RED("availableY")] 
		public CArray<CFloat> AvailableY
		{
			get => GetProperty(ref _availableY);
			set => SetProperty(ref _availableY, value);
		}

		public gameuiRoachRaceDynObjectLogic(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
