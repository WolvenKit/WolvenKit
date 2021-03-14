using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_TargetingInfoDef : gamebbScriptDefinition
	{
		private gamebbScriptID_EntityID _currentVisibleTarget;
		private gamebbScriptID_Float _visibleTargetDistance;
		private gamebbScriptID_Int32 _visibleTargetAttitude;
		private gamebbScriptID_EntityID _currentObstructedTarget;
		private gamebbScriptID_Float _obstructedTargetDistance;
		private gamebbScriptID_Int32 _obstructedTargetAttitude;

		[Ordinal(0)] 
		[RED("CurrentVisibleTarget")] 
		public gamebbScriptID_EntityID CurrentVisibleTarget
		{
			get
			{
				if (_currentVisibleTarget == null)
				{
					_currentVisibleTarget = (gamebbScriptID_EntityID) CR2WTypeManager.Create("gamebbScriptID_EntityID", "CurrentVisibleTarget", cr2w, this);
				}
				return _currentVisibleTarget;
			}
			set
			{
				if (_currentVisibleTarget == value)
				{
					return;
				}
				_currentVisibleTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("VisibleTargetDistance")] 
		public gamebbScriptID_Float VisibleTargetDistance
		{
			get
			{
				if (_visibleTargetDistance == null)
				{
					_visibleTargetDistance = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "VisibleTargetDistance", cr2w, this);
				}
				return _visibleTargetDistance;
			}
			set
			{
				if (_visibleTargetDistance == value)
				{
					return;
				}
				_visibleTargetDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("VisibleTargetAttitude")] 
		public gamebbScriptID_Int32 VisibleTargetAttitude
		{
			get
			{
				if (_visibleTargetAttitude == null)
				{
					_visibleTargetAttitude = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "VisibleTargetAttitude", cr2w, this);
				}
				return _visibleTargetAttitude;
			}
			set
			{
				if (_visibleTargetAttitude == value)
				{
					return;
				}
				_visibleTargetAttitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("CurrentObstructedTarget")] 
		public gamebbScriptID_EntityID CurrentObstructedTarget
		{
			get
			{
				if (_currentObstructedTarget == null)
				{
					_currentObstructedTarget = (gamebbScriptID_EntityID) CR2WTypeManager.Create("gamebbScriptID_EntityID", "CurrentObstructedTarget", cr2w, this);
				}
				return _currentObstructedTarget;
			}
			set
			{
				if (_currentObstructedTarget == value)
				{
					return;
				}
				_currentObstructedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ObstructedTargetDistance")] 
		public gamebbScriptID_Float ObstructedTargetDistance
		{
			get
			{
				if (_obstructedTargetDistance == null)
				{
					_obstructedTargetDistance = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "ObstructedTargetDistance", cr2w, this);
				}
				return _obstructedTargetDistance;
			}
			set
			{
				if (_obstructedTargetDistance == value)
				{
					return;
				}
				_obstructedTargetDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ObstructedTargetAttitude")] 
		public gamebbScriptID_Int32 ObstructedTargetAttitude
		{
			get
			{
				if (_obstructedTargetAttitude == null)
				{
					_obstructedTargetAttitude = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ObstructedTargetAttitude", cr2w, this);
				}
				return _obstructedTargetAttitude;
			}
			set
			{
				if (_obstructedTargetAttitude == value)
				{
					return;
				}
				_obstructedTargetAttitude = value;
				PropertySet(this);
			}
		}

		public UI_TargetingInfoDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
