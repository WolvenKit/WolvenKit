using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class stimInvestigateData : CVariable
	{
		private CArray<Vector4> _investigationSpots;
		private CBool _investigateController;
		private wCHandle<entEntity> _controllerEntity;
		private wCHandle<entEntity> _mainDeviceEntity;
		private Vector4 _distrationPoint;
		private wCHandle<entEntity> _attackInstigator;
		private Vector4 _attackInstigatorPosition;
		private CBool _revealsInstigatorPosition;
		private CBool _illegalAction;
		private CInt32 _fearPhase;
		private CBool _skipReactionDelay;
		private CBool _skipInitialAnimation;

		[Ordinal(0)] 
		[RED("investigationSpots")] 
		public CArray<Vector4> InvestigationSpots
		{
			get
			{
				if (_investigationSpots == null)
				{
					_investigationSpots = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "investigationSpots", cr2w, this);
				}
				return _investigationSpots;
			}
			set
			{
				if (_investigationSpots == value)
				{
					return;
				}
				_investigationSpots = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("investigateController")] 
		public CBool InvestigateController
		{
			get
			{
				if (_investigateController == null)
				{
					_investigateController = (CBool) CR2WTypeManager.Create("Bool", "investigateController", cr2w, this);
				}
				return _investigateController;
			}
			set
			{
				if (_investigateController == value)
				{
					return;
				}
				_investigateController = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("controllerEntity")] 
		public wCHandle<entEntity> ControllerEntity
		{
			get
			{
				if (_controllerEntity == null)
				{
					_controllerEntity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "controllerEntity", cr2w, this);
				}
				return _controllerEntity;
			}
			set
			{
				if (_controllerEntity == value)
				{
					return;
				}
				_controllerEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mainDeviceEntity")] 
		public wCHandle<entEntity> MainDeviceEntity
		{
			get
			{
				if (_mainDeviceEntity == null)
				{
					_mainDeviceEntity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "mainDeviceEntity", cr2w, this);
				}
				return _mainDeviceEntity;
			}
			set
			{
				if (_mainDeviceEntity == value)
				{
					return;
				}
				_mainDeviceEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("distrationPoint")] 
		public Vector4 DistrationPoint
		{
			get
			{
				if (_distrationPoint == null)
				{
					_distrationPoint = (Vector4) CR2WTypeManager.Create("Vector4", "distrationPoint", cr2w, this);
				}
				return _distrationPoint;
			}
			set
			{
				if (_distrationPoint == value)
				{
					return;
				}
				_distrationPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("attackInstigator")] 
		public wCHandle<entEntity> AttackInstigator
		{
			get
			{
				if (_attackInstigator == null)
				{
					_attackInstigator = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "attackInstigator", cr2w, this);
				}
				return _attackInstigator;
			}
			set
			{
				if (_attackInstigator == value)
				{
					return;
				}
				_attackInstigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("attackInstigatorPosition")] 
		public Vector4 AttackInstigatorPosition
		{
			get
			{
				if (_attackInstigatorPosition == null)
				{
					_attackInstigatorPosition = (Vector4) CR2WTypeManager.Create("Vector4", "attackInstigatorPosition", cr2w, this);
				}
				return _attackInstigatorPosition;
			}
			set
			{
				if (_attackInstigatorPosition == value)
				{
					return;
				}
				_attackInstigatorPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("revealsInstigatorPosition")] 
		public CBool RevealsInstigatorPosition
		{
			get
			{
				if (_revealsInstigatorPosition == null)
				{
					_revealsInstigatorPosition = (CBool) CR2WTypeManager.Create("Bool", "revealsInstigatorPosition", cr2w, this);
				}
				return _revealsInstigatorPosition;
			}
			set
			{
				if (_revealsInstigatorPosition == value)
				{
					return;
				}
				_revealsInstigatorPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("illegalAction")] 
		public CBool IllegalAction
		{
			get
			{
				if (_illegalAction == null)
				{
					_illegalAction = (CBool) CR2WTypeManager.Create("Bool", "illegalAction", cr2w, this);
				}
				return _illegalAction;
			}
			set
			{
				if (_illegalAction == value)
				{
					return;
				}
				_illegalAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("fearPhase")] 
		public CInt32 FearPhase
		{
			get
			{
				if (_fearPhase == null)
				{
					_fearPhase = (CInt32) CR2WTypeManager.Create("Int32", "fearPhase", cr2w, this);
				}
				return _fearPhase;
			}
			set
			{
				if (_fearPhase == value)
				{
					return;
				}
				_fearPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("skipReactionDelay")] 
		public CBool SkipReactionDelay
		{
			get
			{
				if (_skipReactionDelay == null)
				{
					_skipReactionDelay = (CBool) CR2WTypeManager.Create("Bool", "skipReactionDelay", cr2w, this);
				}
				return _skipReactionDelay;
			}
			set
			{
				if (_skipReactionDelay == value)
				{
					return;
				}
				_skipReactionDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("skipInitialAnimation")] 
		public CBool SkipInitialAnimation
		{
			get
			{
				if (_skipInitialAnimation == null)
				{
					_skipInitialAnimation = (CBool) CR2WTypeManager.Create("Bool", "skipInitialAnimation", cr2w, this);
				}
				return _skipInitialAnimation;
			}
			set
			{
				if (_skipInitialAnimation == value)
				{
					return;
				}
				_skipInitialAnimation = value;
				PropertySet(this);
			}
		}

		public stimInvestigateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
