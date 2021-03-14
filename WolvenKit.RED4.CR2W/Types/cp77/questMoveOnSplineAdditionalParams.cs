using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMoveOnSplineAdditionalParams : ISerializable
	{
		private CEnum<questMoveOnSplineType> _type;
		private questSimpleMoveOnSplineParams _simpleParams;
		private questAnimMoveOnSplineParams _animParams;
		private questWithCompanionMoveOnSplineParams _withCompanionParams;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questMoveOnSplineType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<questMoveOnSplineType>) CR2WTypeManager.Create("questMoveOnSplineType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("simpleParams")] 
		public questSimpleMoveOnSplineParams SimpleParams
		{
			get
			{
				if (_simpleParams == null)
				{
					_simpleParams = (questSimpleMoveOnSplineParams) CR2WTypeManager.Create("questSimpleMoveOnSplineParams", "simpleParams", cr2w, this);
				}
				return _simpleParams;
			}
			set
			{
				if (_simpleParams == value)
				{
					return;
				}
				_simpleParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animParams")] 
		public questAnimMoveOnSplineParams AnimParams
		{
			get
			{
				if (_animParams == null)
				{
					_animParams = (questAnimMoveOnSplineParams) CR2WTypeManager.Create("questAnimMoveOnSplineParams", "animParams", cr2w, this);
				}
				return _animParams;
			}
			set
			{
				if (_animParams == value)
				{
					return;
				}
				_animParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("withCompanionParams")] 
		public questWithCompanionMoveOnSplineParams WithCompanionParams
		{
			get
			{
				if (_withCompanionParams == null)
				{
					_withCompanionParams = (questWithCompanionMoveOnSplineParams) CR2WTypeManager.Create("questWithCompanionMoveOnSplineParams", "withCompanionParams", cr2w, this);
				}
				return _withCompanionParams;
			}
			set
			{
				if (_withCompanionParams == value)
				{
					return;
				}
				_withCompanionParams = value;
				PropertySet(this);
			}
		}

		public questMoveOnSplineAdditionalParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
