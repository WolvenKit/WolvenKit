using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VentilationAreaControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("ventilationAreaSetup")] public VentilationAreaSetup VentilationAreaSetup { get; set; }
		[Ordinal(105)] [RED("isActive")] public CBool IsActive { get; set; }

		public VentilationAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
