using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyStatGroupEffector : gameEffector
	{
		private wCHandle<gameObject> _effectorOwner;
		private gameStatsObjectID _target;
		private TweakDBID _record;
		private CString _applicationTarget;
		private CUInt64 _modGroupID;

		[Ordinal(0)] 
		[RED("effectorOwner")] 
		public wCHandle<gameObject> EffectorOwner
		{
			get
			{
				if (_effectorOwner == null)
				{
					_effectorOwner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "effectorOwner", cr2w, this);
				}
				return _effectorOwner;
			}
			set
			{
				if (_effectorOwner == value)
				{
					return;
				}
				_effectorOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public gameStatsObjectID Target
		{
			get
			{
				if (_target == null)
				{
					_target = (gameStatsObjectID) CR2WTypeManager.Create("gameStatsObjectID", "target", cr2w, this);
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
		[RED("record")] 
		public TweakDBID Record
		{
			get
			{
				if (_record == null)
				{
					_record = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "record", cr2w, this);
				}
				return _record;
			}
			set
			{
				if (_record == value)
				{
					return;
				}
				_record = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("applicationTarget")] 
		public CString ApplicationTarget
		{
			get
			{
				if (_applicationTarget == null)
				{
					_applicationTarget = (CString) CR2WTypeManager.Create("String", "applicationTarget", cr2w, this);
				}
				return _applicationTarget;
			}
			set
			{
				if (_applicationTarget == value)
				{
					return;
				}
				_applicationTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("modGroupID")] 
		public CUInt64 ModGroupID
		{
			get
			{
				if (_modGroupID == null)
				{
					_modGroupID = (CUInt64) CR2WTypeManager.Create("Uint64", "modGroupID", cr2w, this);
				}
				return _modGroupID;
			}
			set
			{
				if (_modGroupID == value)
				{
					return;
				}
				_modGroupID = value;
				PropertySet(this);
			}
		}

		public ApplyStatGroupEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
