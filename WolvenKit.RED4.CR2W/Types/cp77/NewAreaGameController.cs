using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewAreaGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _label;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<NewAreaDiscoveredUserData> _data;

		[Ordinal(9)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<NewAreaDiscoveredUserData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<NewAreaDiscoveredUserData>) CR2WTypeManager.Create("handle:NewAreaDiscoveredUserData", "data", cr2w, this);
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

		public NewAreaGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
