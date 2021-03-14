using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceDismembermentEffector : gameEffector
	{
		private CEnum<gameDismBodyPart> _bodyPart;
		private CEnum<gameDismWoundType> _woundType;
		private CBool _isCritical;
		private CBool _skipDeathAnim;
		private CBool _shouldKillNPC;
		private CFloat _dismembermentChance;
		private CHandle<gamedataForceDismembermentEffector_Record> _effectorRecord;

		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<gameDismBodyPart> BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CEnum<gameDismBodyPart>) CR2WTypeManager.Create("gameDismBodyPart", "bodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("woundType")] 
		public CEnum<gameDismWoundType> WoundType
		{
			get
			{
				if (_woundType == null)
				{
					_woundType = (CEnum<gameDismWoundType>) CR2WTypeManager.Create("gameDismWoundType", "woundType", cr2w, this);
				}
				return _woundType;
			}
			set
			{
				if (_woundType == value)
				{
					return;
				}
				_woundType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isCritical")] 
		public CBool IsCritical
		{
			get
			{
				if (_isCritical == null)
				{
					_isCritical = (CBool) CR2WTypeManager.Create("Bool", "isCritical", cr2w, this);
				}
				return _isCritical;
			}
			set
			{
				if (_isCritical == value)
				{
					return;
				}
				_isCritical = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("skipDeathAnim")] 
		public CBool SkipDeathAnim
		{
			get
			{
				if (_skipDeathAnim == null)
				{
					_skipDeathAnim = (CBool) CR2WTypeManager.Create("Bool", "skipDeathAnim", cr2w, this);
				}
				return _skipDeathAnim;
			}
			set
			{
				if (_skipDeathAnim == value)
				{
					return;
				}
				_skipDeathAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("shouldKillNPC")] 
		public CBool ShouldKillNPC
		{
			get
			{
				if (_shouldKillNPC == null)
				{
					_shouldKillNPC = (CBool) CR2WTypeManager.Create("Bool", "shouldKillNPC", cr2w, this);
				}
				return _shouldKillNPC;
			}
			set
			{
				if (_shouldKillNPC == value)
				{
					return;
				}
				_shouldKillNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dismembermentChance")] 
		public CFloat DismembermentChance
		{
			get
			{
				if (_dismembermentChance == null)
				{
					_dismembermentChance = (CFloat) CR2WTypeManager.Create("Float", "dismembermentChance", cr2w, this);
				}
				return _dismembermentChance;
			}
			set
			{
				if (_dismembermentChance == value)
				{
					return;
				}
				_dismembermentChance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("effectorRecord")] 
		public CHandle<gamedataForceDismembermentEffector_Record> EffectorRecord
		{
			get
			{
				if (_effectorRecord == null)
				{
					_effectorRecord = (CHandle<gamedataForceDismembermentEffector_Record>) CR2WTypeManager.Create("handle:gamedataForceDismembermentEffector_Record", "effectorRecord", cr2w, this);
				}
				return _effectorRecord;
			}
			set
			{
				if (_effectorRecord == value)
				{
					return;
				}
				_effectorRecord = value;
				PropertySet(this);
			}
		}

		public ForceDismembermentEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
