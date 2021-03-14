using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIApproachingAreaEvent : AIAIEvent
	{
		private CBool _isApproachCancellation;
		private wCHandle<gameStaticAreaShapeComponent> _areaComponent;
		private wCHandle<entEntity> _responseTarget;

		[Ordinal(2)] 
		[RED("isApproachCancellation")] 
		public CBool IsApproachCancellation
		{
			get
			{
				if (_isApproachCancellation == null)
				{
					_isApproachCancellation = (CBool) CR2WTypeManager.Create("Bool", "isApproachCancellation", cr2w, this);
				}
				return _isApproachCancellation;
			}
			set
			{
				if (_isApproachCancellation == value)
				{
					return;
				}
				_isApproachCancellation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("responseTarget")] 
		public wCHandle<entEntity> ResponseTarget
		{
			get
			{
				if (_responseTarget == null)
				{
					_responseTarget = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "responseTarget", cr2w, this);
				}
				return _responseTarget;
			}
			set
			{
				if (_responseTarget == value)
				{
					return;
				}
				_responseTarget = value;
				PropertySet(this);
			}
		}

		public AIApproachingAreaEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
