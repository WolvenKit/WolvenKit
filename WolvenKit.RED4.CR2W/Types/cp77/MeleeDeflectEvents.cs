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
			get
			{
				if (_deflectStatFlag == null)
				{
					_deflectStatFlag = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "deflectStatFlag", cr2w, this);
				}
				return _deflectStatFlag;
			}
			set
			{
				if (_deflectStatFlag == value)
				{
					return;
				}
				_deflectStatFlag = value;
				PropertySet(this);
			}
		}

		public MeleeDeflectEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
