using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_SetDeathDirection : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CEnum<gameeventsDeathDirection> _direction;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<gameeventsDeathDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		public questCharacterManagerCombat_SetDeathDirection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
