using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceNPC : ActivatedDeviceTransfromAnim
	{
		private CBool _hasProperAnimations;

		[Ordinal(94)] 
		[RED("hasProperAnimations")] 
		public CBool HasProperAnimations
		{
			get => GetProperty(ref _hasProperAnimations);
			set => SetProperty(ref _hasProperAnimations, value);
		}

		public ActivatedDeviceNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
