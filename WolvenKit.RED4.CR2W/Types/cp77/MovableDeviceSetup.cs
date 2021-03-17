using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MovableDeviceSetup : CVariable
	{
		private CInt32 _numberOfUses;

		[Ordinal(0)] 
		[RED("numberOfUses")] 
		public CInt32 NumberOfUses
		{
			get => GetProperty(ref _numberOfUses);
			set => SetProperty(ref _numberOfUses, value);
		}

		public MovableDeviceSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
