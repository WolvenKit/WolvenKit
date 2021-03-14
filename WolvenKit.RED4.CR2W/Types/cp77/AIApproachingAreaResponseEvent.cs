using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIApproachingAreaResponseEvent : redEvent
	{
		private wCHandle<entEntity> _sender;
		private wCHandle<gameStaticAreaShapeComponent> _areaComponent;
		private CBool _isPassingThrough;

		[Ordinal(0)] 
		[RED("sender")] 
		public wCHandle<entEntity> Sender
		{
			get
			{
				if (_sender == null)
				{
					_sender = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "sender", cr2w, this);
				}
				return _sender;
			}
			set
			{
				if (_sender == value)
				{
					return;
				}
				_sender = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("areaComponent")] 
		public wCHandle<gameStaticAreaShapeComponent> AreaComponent
		{
			get
			{
				if (_areaComponent == null)
				{
					_areaComponent = (wCHandle<gameStaticAreaShapeComponent>) CR2WTypeManager.Create("whandle:gameStaticAreaShapeComponent", "areaComponent", cr2w, this);
				}
				return _areaComponent;
			}
			set
			{
				if (_areaComponent == value)
				{
					return;
				}
				_areaComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isPassingThrough")] 
		public CBool IsPassingThrough
		{
			get
			{
				if (_isPassingThrough == null)
				{
					_isPassingThrough = (CBool) CR2WTypeManager.Create("Bool", "isPassingThrough", cr2w, this);
				}
				return _isPassingThrough;
			}
			set
			{
				if (_isPassingThrough == value)
				{
					return;
				}
				_isPassingThrough = value;
				PropertySet(this);
			}
		}

		public AIApproachingAreaResponseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
