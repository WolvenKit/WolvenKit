using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowGrenadeCommandCleanup : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetProperty(ref _inCommand);
			set => SetProperty(ref _inCommand, value);
		}

		public ThrowGrenadeCommandCleanup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
