using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SHitOperationData : CVariable
	{
		private CBool _isAttackerPlayer;
		private CBool _isAttackerNPC;
		private CBool _bullets;
		private CBool _explosions;
		private CBool _melee;
		private CFloat _healthPercentage;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("isAttackerPlayer")] 
		public CBool IsAttackerPlayer
		{
			get
			{
				if (_isAttackerPlayer == null)
				{
					_isAttackerPlayer = (CBool) CR2WTypeManager.Create("Bool", "isAttackerPlayer", cr2w, this);
				}
				return _isAttackerPlayer;
			}
			set
			{
				if (_isAttackerPlayer == value)
				{
					return;
				}
				_isAttackerPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isAttackerNPC")] 
		public CBool IsAttackerNPC
		{
			get
			{
				if (_isAttackerNPC == null)
				{
					_isAttackerNPC = (CBool) CR2WTypeManager.Create("Bool", "isAttackerNPC", cr2w, this);
				}
				return _isAttackerNPC;
			}
			set
			{
				if (_isAttackerNPC == value)
				{
					return;
				}
				_isAttackerNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bullets")] 
		public CBool Bullets
		{
			get
			{
				if (_bullets == null)
				{
					_bullets = (CBool) CR2WTypeManager.Create("Bool", "bullets", cr2w, this);
				}
				return _bullets;
			}
			set
			{
				if (_bullets == value)
				{
					return;
				}
				_bullets = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("explosions")] 
		public CBool Explosions
		{
			get
			{
				if (_explosions == null)
				{
					_explosions = (CBool) CR2WTypeManager.Create("Bool", "explosions", cr2w, this);
				}
				return _explosions;
			}
			set
			{
				if (_explosions == value)
				{
					return;
				}
				_explosions = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("melee")] 
		public CBool Melee
		{
			get
			{
				if (_melee == null)
				{
					_melee = (CBool) CR2WTypeManager.Create("Bool", "melee", cr2w, this);
				}
				return _melee;
			}
			set
			{
				if (_melee == value)
				{
					return;
				}
				_melee = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("healthPercentage")] 
		public CFloat HealthPercentage
		{
			get
			{
				if (_healthPercentage == null)
				{
					_healthPercentage = (CFloat) CR2WTypeManager.Create("Float", "healthPercentage", cr2w, this);
				}
				return _healthPercentage;
			}
			set
			{
				if (_healthPercentage == value)
				{
					return;
				}
				_healthPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (SBaseDeviceOperationData) CR2WTypeManager.Create("SBaseDeviceOperationData", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		public SHitOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
