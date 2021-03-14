using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMovePuppetNodeParams : questAICommandParams
	{
		private CEnum<questMoveType> _moveType;
		private CHandle<questMoveOnSplineParams> _moveOnSplineParams;
		private CHandle<questMoveToParams> _moveToParams;
		private CHandle<questAICommandParams> _otherParams;
		private CBool _repeatCommandOnInterrupt;

		[Ordinal(0)] 
		[RED("moveType")] 
		public CEnum<questMoveType> MoveType
		{
			get
			{
				if (_moveType == null)
				{
					_moveType = (CEnum<questMoveType>) CR2WTypeManager.Create("questMoveType", "moveType", cr2w, this);
				}
				return _moveType;
			}
			set
			{
				if (_moveType == value)
				{
					return;
				}
				_moveType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("moveOnSplineParams")] 
		public CHandle<questMoveOnSplineParams> MoveOnSplineParams
		{
			get
			{
				if (_moveOnSplineParams == null)
				{
					_moveOnSplineParams = (CHandle<questMoveOnSplineParams>) CR2WTypeManager.Create("handle:questMoveOnSplineParams", "moveOnSplineParams", cr2w, this);
				}
				return _moveOnSplineParams;
			}
			set
			{
				if (_moveOnSplineParams == value)
				{
					return;
				}
				_moveOnSplineParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("moveToParams")] 
		public CHandle<questMoveToParams> MoveToParams
		{
			get
			{
				if (_moveToParams == null)
				{
					_moveToParams = (CHandle<questMoveToParams>) CR2WTypeManager.Create("handle:questMoveToParams", "moveToParams", cr2w, this);
				}
				return _moveToParams;
			}
			set
			{
				if (_moveToParams == value)
				{
					return;
				}
				_moveToParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("otherParams")] 
		public CHandle<questAICommandParams> OtherParams
		{
			get
			{
				if (_otherParams == null)
				{
					_otherParams = (CHandle<questAICommandParams>) CR2WTypeManager.Create("handle:questAICommandParams", "otherParams", cr2w, this);
				}
				return _otherParams;
			}
			set
			{
				if (_otherParams == value)
				{
					return;
				}
				_otherParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get
			{
				if (_repeatCommandOnInterrupt == null)
				{
					_repeatCommandOnInterrupt = (CBool) CR2WTypeManager.Create("Bool", "repeatCommandOnInterrupt", cr2w, this);
				}
				return _repeatCommandOnInterrupt;
			}
			set
			{
				if (_repeatCommandOnInterrupt == value)
				{
					return;
				}
				_repeatCommandOnInterrupt = value;
				PropertySet(this);
			}
		}

		public questMovePuppetNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
