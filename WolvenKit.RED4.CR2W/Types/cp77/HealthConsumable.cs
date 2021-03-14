using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HealthConsumable : gameCpoPickableItem
	{
		private CHandle<gameinteractionsComponent> _interactionComponent;
		private CHandle<entMeshComponent> _meshComponent;
		private CBool _disappearAfterEquip;
		private CFloat _respawnTime;

		[Ordinal(42)] 
		[RED("interactionComponent")] 
		public CHandle<gameinteractionsComponent> InteractionComponent
		{
			get
			{
				if (_interactionComponent == null)
				{
					_interactionComponent = (CHandle<gameinteractionsComponent>) CR2WTypeManager.Create("handle:gameinteractionsComponent", "interactionComponent", cr2w, this);
				}
				return _interactionComponent;
			}
			set
			{
				if (_interactionComponent == value)
				{
					return;
				}
				_interactionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("meshComponent")] 
		public CHandle<entMeshComponent> MeshComponent
		{
			get
			{
				if (_meshComponent == null)
				{
					_meshComponent = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "meshComponent", cr2w, this);
				}
				return _meshComponent;
			}
			set
			{
				if (_meshComponent == value)
				{
					return;
				}
				_meshComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("disappearAfterEquip")] 
		public CBool DisappearAfterEquip
		{
			get
			{
				if (_disappearAfterEquip == null)
				{
					_disappearAfterEquip = (CBool) CR2WTypeManager.Create("Bool", "disappearAfterEquip", cr2w, this);
				}
				return _disappearAfterEquip;
			}
			set
			{
				if (_disappearAfterEquip == value)
				{
					return;
				}
				_disappearAfterEquip = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("respawnTime")] 
		public CFloat RespawnTime
		{
			get
			{
				if (_respawnTime == null)
				{
					_respawnTime = (CFloat) CR2WTypeManager.Create("Float", "respawnTime", cr2w, this);
				}
				return _respawnTime;
			}
			set
			{
				if (_respawnTime == value)
				{
					return;
				}
				_respawnTime = value;
				PropertySet(this);
			}
		}

		public HealthConsumable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
