using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RetractableAd : BaseAnimatedDevice
	{
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnection;
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;
		private CHandle<entIComponent> _advUiComponent;
		private CBool _isPartOfTheTrap;

		[Ordinal(98)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get
			{
				if (_offMeshConnection == null)
				{
					_offMeshConnection = (CHandle<AIOffMeshConnectionComponent>) CR2WTypeManager.Create("handle:AIOffMeshConnectionComponent", "offMeshConnection", cr2w, this);
				}
				return _offMeshConnection;
			}
			set
			{
				if (_offMeshConnection == value)
				{
					return;
				}
				_offMeshConnection = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get
			{
				if (_areaComponent == null)
				{
					_areaComponent = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "areaComponent", cr2w, this);
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

		[Ordinal(100)] 
		[RED("advUiComponent")] 
		public CHandle<entIComponent> AdvUiComponent
		{
			get
			{
				if (_advUiComponent == null)
				{
					_advUiComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "advUiComponent", cr2w, this);
				}
				return _advUiComponent;
			}
			set
			{
				if (_advUiComponent == value)
				{
					return;
				}
				_advUiComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("isPartOfTheTrap")] 
		public CBool IsPartOfTheTrap
		{
			get
			{
				if (_isPartOfTheTrap == null)
				{
					_isPartOfTheTrap = (CBool) CR2WTypeManager.Create("Bool", "isPartOfTheTrap", cr2w, this);
				}
				return _isPartOfTheTrap;
			}
			set
			{
				if (_isPartOfTheTrap == value)
				{
					return;
				}
				_isPartOfTheTrap = value;
				PropertySet(this);
			}
		}

		public RetractableAd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
