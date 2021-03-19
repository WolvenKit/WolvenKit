using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VentilationAreaControllerPS : MasterControllerPS
	{
		private VentilationAreaSetup _ventilationAreaSetup;
		private CBool _isActive;

		[Ordinal(104)] 
		[RED("ventilationAreaSetup")] 
		public VentilationAreaSetup VentilationAreaSetup
		{
			get => GetProperty(ref _ventilationAreaSetup);
			set => SetProperty(ref _ventilationAreaSetup, value);
		}

		[Ordinal(105)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		public VentilationAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
