using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelUpGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _value;
		private inkTextWidgetReference _proficencyLabel;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<LevelUpUserData> _data;

		[Ordinal(9)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get
			{
				if (_value == null)
				{
					_value = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("proficencyLabel")] 
		public inkTextWidgetReference ProficencyLabel
		{
			get
			{
				if (_proficencyLabel == null)
				{
					_proficencyLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "proficencyLabel", cr2w, this);
				}
				return _proficencyLabel;
			}
			set
			{
				if (_proficencyLabel == value)
				{
					return;
				}
				_proficencyLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("data")] 
		public CHandle<LevelUpUserData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<LevelUpUserData>) CR2WTypeManager.Create("handle:LevelUpUserData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public LevelUpGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
