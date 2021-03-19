using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RetractableAdControllerPS : BaseAnimatedDeviceControllerPS
	{
		private CBool _isControlled;

		[Ordinal(108)] 
		[RED("isControlled")] 
		public CBool IsControlled
		{
			get => GetProperty(ref _isControlled);
			set => SetProperty(ref _isControlled, value);
		}

		public RetractableAdControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
