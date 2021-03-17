using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScanInstance : ModuleInstance
	{
		private CBool _isScanningCluesBlocked;

		[Ordinal(6)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get => GetProperty(ref _isScanningCluesBlocked);
			set => SetProperty(ref _isScanningCluesBlocked, value);
		}

		public ScanInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
