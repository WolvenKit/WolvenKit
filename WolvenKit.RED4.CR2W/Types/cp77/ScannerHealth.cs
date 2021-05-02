using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerHealth : ScannerChunk
	{
		private CInt32 _currentHealth;
		private CInt32 _totalHealth;

		[Ordinal(0)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(1)] 
		[RED("totalHealth")] 
		public CInt32 TotalHealth
		{
			get => GetProperty(ref _totalHealth);
			set => SetProperty(ref _totalHealth, value);
		}

		public ScannerHealth(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
