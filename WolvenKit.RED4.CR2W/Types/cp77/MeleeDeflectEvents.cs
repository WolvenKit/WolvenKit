using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeDeflectEvents : MeleeEventsTransition
	{
		private CHandle<gameStatModifierData> _deflectStatFlag;

		[Ordinal(0)] 
		[RED("deflectStatFlag")] 
		public CHandle<gameStatModifierData> DeflectStatFlag
		{
			get => GetProperty(ref _deflectStatFlag);
			set => SetProperty(ref _deflectStatFlag, value);
		}

		public MeleeDeflectEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
