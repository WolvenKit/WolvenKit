using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIEnemyPushedToSquad : AIAIEvent
	{
		private wCHandle<entEntity> _threat;

		[Ordinal(2)] 
		[RED("threat")] 
		public wCHandle<entEntity> Threat
		{
			get
			{
				if (_threat == null)
				{
					_threat = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "threat", cr2w, this);
				}
				return _threat;
			}
			set
			{
				if (_threat == value)
				{
					return;
				}
				_threat = value;
				PropertySet(this);
			}
		}

		public AIEnemyPushedToSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
