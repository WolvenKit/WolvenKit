using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClaymoreMine : gameweaponObject
	{
		private CHandle<entMeshComponent> _visualComponent;
		private CHandle<entMeshComponent> _triggerAreaIndicator;
		private CHandle<entSimpleColliderComponent> _shootCollision;
		private CHandle<gameStaticTriggerAreaComponent> _triggerComponent;
		private CBool _alive;
		private CBool _armed;

		[Ordinal(57)] 
		[RED("visualComponent")] 
		public CHandle<entMeshComponent> VisualComponent
		{
			get
			{
				if (_visualComponent == null)
				{
					_visualComponent = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "visualComponent", cr2w, this);
				}
				return _visualComponent;
			}
			set
			{
				if (_visualComponent == value)
				{
					return;
				}
				_visualComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("triggerAreaIndicator")] 
		public CHandle<entMeshComponent> TriggerAreaIndicator
		{
			get
			{
				if (_triggerAreaIndicator == null)
				{
					_triggerAreaIndicator = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "triggerAreaIndicator", cr2w, this);
				}
				return _triggerAreaIndicator;
			}
			set
			{
				if (_triggerAreaIndicator == value)
				{
					return;
				}
				_triggerAreaIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("shootCollision")] 
		public CHandle<entSimpleColliderComponent> ShootCollision
		{
			get
			{
				if (_shootCollision == null)
				{
					_shootCollision = (CHandle<entSimpleColliderComponent>) CR2WTypeManager.Create("handle:entSimpleColliderComponent", "shootCollision", cr2w, this);
				}
				return _shootCollision;
			}
			set
			{
				if (_shootCollision == value)
				{
					return;
				}
				_shootCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("triggerComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerComponent
		{
			get
			{
				if (_triggerComponent == null)
				{
					_triggerComponent = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "triggerComponent", cr2w, this);
				}
				return _triggerComponent;
			}
			set
			{
				if (_triggerComponent == value)
				{
					return;
				}
				_triggerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("alive")] 
		public CBool Alive
		{
			get
			{
				if (_alive == null)
				{
					_alive = (CBool) CR2WTypeManager.Create("Bool", "alive", cr2w, this);
				}
				return _alive;
			}
			set
			{
				if (_alive == value)
				{
					return;
				}
				_alive = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("armed")] 
		public CBool Armed
		{
			get
			{
				if (_armed == null)
				{
					_armed = (CBool) CR2WTypeManager.Create("Bool", "armed", cr2w, this);
				}
				return _armed;
			}
			set
			{
				if (_armed == value)
				{
					return;
				}
				_armed = value;
				PropertySet(this);
			}
		}

		public ClaymoreMine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
