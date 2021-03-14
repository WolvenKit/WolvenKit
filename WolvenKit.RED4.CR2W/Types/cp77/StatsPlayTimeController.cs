using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsPlayTimeController : inkWidgetLogicController
	{
		private inkTextWidgetReference _playTimeRef;
		private inkTextWidgetReference _lifePathRef;
		private inkImageWidgetReference _lifePathIconRef;

		[Ordinal(1)] 
		[RED("playTimeRef")] 
		public inkTextWidgetReference PlayTimeRef
		{
			get
			{
				if (_playTimeRef == null)
				{
					_playTimeRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "playTimeRef", cr2w, this);
				}
				return _playTimeRef;
			}
			set
			{
				if (_playTimeRef == value)
				{
					return;
				}
				_playTimeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lifePathRef")] 
		public inkTextWidgetReference LifePathRef
		{
			get
			{
				if (_lifePathRef == null)
				{
					_lifePathRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "lifePathRef", cr2w, this);
				}
				return _lifePathRef;
			}
			set
			{
				if (_lifePathRef == value)
				{
					return;
				}
				_lifePathRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lifePathIconRef")] 
		public inkImageWidgetReference LifePathIconRef
		{
			get
			{
				if (_lifePathIconRef == null)
				{
					_lifePathIconRef = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "lifePathIconRef", cr2w, this);
				}
				return _lifePathIconRef;
			}
			set
			{
				if (_lifePathIconRef == value)
				{
					return;
				}
				_lifePathIconRef = value;
				PropertySet(this);
			}
		}

		public StatsPlayTimeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
