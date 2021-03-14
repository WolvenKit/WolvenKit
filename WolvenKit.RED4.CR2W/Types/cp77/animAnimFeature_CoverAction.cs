using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_CoverAction : animAnimFeature_AIAction
	{
		private CInt32 _coverStance;
		private CInt32 _coverActionType;
		private CInt32 _coverShootType;
		private CInt32 _movementType;

		[Ordinal(4)] 
		[RED("coverStance")] 
		public CInt32 CoverStance
		{
			get
			{
				if (_coverStance == null)
				{
					_coverStance = (CInt32) CR2WTypeManager.Create("Int32", "coverStance", cr2w, this);
				}
				return _coverStance;
			}
			set
			{
				if (_coverStance == value)
				{
					return;
				}
				_coverStance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("coverActionType")] 
		public CInt32 CoverActionType
		{
			get
			{
				if (_coverActionType == null)
				{
					_coverActionType = (CInt32) CR2WTypeManager.Create("Int32", "coverActionType", cr2w, this);
				}
				return _coverActionType;
			}
			set
			{
				if (_coverActionType == value)
				{
					return;
				}
				_coverActionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("coverShootType")] 
		public CInt32 CoverShootType
		{
			get
			{
				if (_coverShootType == null)
				{
					_coverShootType = (CInt32) CR2WTypeManager.Create("Int32", "coverShootType", cr2w, this);
				}
				return _coverShootType;
			}
			set
			{
				if (_coverShootType == value)
				{
					return;
				}
				_coverShootType = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("movementType")] 
		public CInt32 MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CInt32) CR2WTypeManager.Create("Int32", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_CoverAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
