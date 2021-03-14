using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveOnSplineCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outSpline;
		private CHandle<AIArgumentMapping> _outMovementType;
		private CHandle<AIArgumentMapping> _outRotateTowardsFacingTarget;
		private CHandle<AIArgumentMapping> _outFacingTarget;
		private CHandle<AIArgumentMapping> _outSnapToTerrain;

		[Ordinal(1)] 
		[RED("outSpline")] 
		public CHandle<AIArgumentMapping> OutSpline
		{
			get
			{
				if (_outSpline == null)
				{
					_outSpline = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outSpline", cr2w, this);
				}
				return _outSpline;
			}
			set
			{
				if (_outSpline == value)
				{
					return;
				}
				_outSpline = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outMovementType")] 
		public CHandle<AIArgumentMapping> OutMovementType
		{
			get
			{
				if (_outMovementType == null)
				{
					_outMovementType = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outMovementType", cr2w, this);
				}
				return _outMovementType;
			}
			set
			{
				if (_outMovementType == value)
				{
					return;
				}
				_outMovementType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("outRotateTowardsFacingTarget")] 
		public CHandle<AIArgumentMapping> OutRotateTowardsFacingTarget
		{
			get
			{
				if (_outRotateTowardsFacingTarget == null)
				{
					_outRotateTowardsFacingTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outRotateTowardsFacingTarget", cr2w, this);
				}
				return _outRotateTowardsFacingTarget;
			}
			set
			{
				if (_outRotateTowardsFacingTarget == value)
				{
					return;
				}
				_outRotateTowardsFacingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("outFacingTarget")] 
		public CHandle<AIArgumentMapping> OutFacingTarget
		{
			get
			{
				if (_outFacingTarget == null)
				{
					_outFacingTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outFacingTarget", cr2w, this);
				}
				return _outFacingTarget;
			}
			set
			{
				if (_outFacingTarget == value)
				{
					return;
				}
				_outFacingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("outSnapToTerrain")] 
		public CHandle<AIArgumentMapping> OutSnapToTerrain
		{
			get
			{
				if (_outSnapToTerrain == null)
				{
					_outSnapToTerrain = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outSnapToTerrain", cr2w, this);
				}
				return _outSnapToTerrain;
			}
			set
			{
				if (_outSnapToTerrain == value)
				{
					return;
				}
				_outSnapToTerrain = value;
				PropertySet(this);
			}
		}

		public AIMoveOnSplineCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
