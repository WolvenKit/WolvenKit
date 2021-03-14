using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AINavigationSystemQuery : CVariable
	{
		private AIPositionSpec _source;
		private AIPositionSpec _target;
		private CArray<CName> _allowedTags;
		private CArray<CName> _blockedTags;
		private CFloat _minDesiredDistance;
		private CFloat _maxDesiredDistance;
		private CBool _useFollowSlots;
		private CBool _usePredictionTime;

		[Ordinal(0)] 
		[RED("source")] 
		public AIPositionSpec Source
		{
			get
			{
				if (_source == null)
				{
					_source = (AIPositionSpec) CR2WTypeManager.Create("AIPositionSpec", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public AIPositionSpec Target
		{
			get
			{
				if (_target == null)
				{
					_target = (AIPositionSpec) CR2WTypeManager.Create("AIPositionSpec", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("allowedTags")] 
		public CArray<CName> AllowedTags
		{
			get
			{
				if (_allowedTags == null)
				{
					_allowedTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "allowedTags", cr2w, this);
				}
				return _allowedTags;
			}
			set
			{
				if (_allowedTags == value)
				{
					return;
				}
				_allowedTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("blockedTags")] 
		public CArray<CName> BlockedTags
		{
			get
			{
				if (_blockedTags == null)
				{
					_blockedTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "blockedTags", cr2w, this);
				}
				return _blockedTags;
			}
			set
			{
				if (_blockedTags == value)
				{
					return;
				}
				_blockedTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("minDesiredDistance")] 
		public CFloat MinDesiredDistance
		{
			get
			{
				if (_minDesiredDistance == null)
				{
					_minDesiredDistance = (CFloat) CR2WTypeManager.Create("Float", "minDesiredDistance", cr2w, this);
				}
				return _minDesiredDistance;
			}
			set
			{
				if (_minDesiredDistance == value)
				{
					return;
				}
				_minDesiredDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxDesiredDistance")] 
		public CFloat MaxDesiredDistance
		{
			get
			{
				if (_maxDesiredDistance == null)
				{
					_maxDesiredDistance = (CFloat) CR2WTypeManager.Create("Float", "maxDesiredDistance", cr2w, this);
				}
				return _maxDesiredDistance;
			}
			set
			{
				if (_maxDesiredDistance == value)
				{
					return;
				}
				_maxDesiredDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("useFollowSlots")] 
		public CBool UseFollowSlots
		{
			get
			{
				if (_useFollowSlots == null)
				{
					_useFollowSlots = (CBool) CR2WTypeManager.Create("Bool", "useFollowSlots", cr2w, this);
				}
				return _useFollowSlots;
			}
			set
			{
				if (_useFollowSlots == value)
				{
					return;
				}
				_useFollowSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("usePredictionTime")] 
		public CBool UsePredictionTime
		{
			get
			{
				if (_usePredictionTime == null)
				{
					_usePredictionTime = (CBool) CR2WTypeManager.Create("Bool", "usePredictionTime", cr2w, this);
				}
				return _usePredictionTime;
			}
			set
			{
				if (_usePredictionTime == value)
				{
					return;
				}
				_usePredictionTime = value;
				PropertySet(this);
			}
		}

		public AINavigationSystemQuery(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
