using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisplayGlassControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isTinted;
		private CBool _useAppearances;
		private CName _clearAppearance;
		private CName _tintedAppearance;

		[Ordinal(103)] 
		[RED("isTinted")] 
		public CBool IsTinted
		{
			get => GetProperty(ref _isTinted);
			set => SetProperty(ref _isTinted, value);
		}

		[Ordinal(104)] 
		[RED("useAppearances")] 
		public CBool UseAppearances
		{
			get => GetProperty(ref _useAppearances);
			set => SetProperty(ref _useAppearances, value);
		}

		[Ordinal(105)] 
		[RED("clearAppearance")] 
		public CName ClearAppearance
		{
			get => GetProperty(ref _clearAppearance);
			set => SetProperty(ref _clearAppearance, value);
		}

		[Ordinal(106)] 
		[RED("tintedAppearance")] 
		public CName TintedAppearance
		{
			get => GetProperty(ref _tintedAppearance);
			set => SetProperty(ref _tintedAppearance, value);
		}

		public DisplayGlassControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
