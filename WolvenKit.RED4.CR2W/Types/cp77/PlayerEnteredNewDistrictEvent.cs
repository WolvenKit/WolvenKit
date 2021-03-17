using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerEnteredNewDistrictEvent : redEvent
	{
		private CFloat _gunshotRange;
		private CFloat _explosionRange;

		[Ordinal(0)] 
		[RED("gunshotRange")] 
		public CFloat GunshotRange
		{
			get => GetProperty(ref _gunshotRange);
			set => SetProperty(ref _gunshotRange, value);
		}

		[Ordinal(1)] 
		[RED("explosionRange")] 
		public CFloat ExplosionRange
		{
			get => GetProperty(ref _explosionRange);
			set => SetProperty(ref _explosionRange, value);
		}

		public PlayerEnteredNewDistrictEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
