using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCorrectivePoseEntry : CVariable
	{
		private CName _comparePose;
		private CName _correctivePose;
		private CArray<CName> _jointsToCompare;
		private CBool _enabled;

		[Ordinal(0)] 
		[RED("comparePose")] 
		public CName ComparePose
		{
			get
			{
				if (_comparePose == null)
				{
					_comparePose = (CName) CR2WTypeManager.Create("CName", "comparePose", cr2w, this);
				}
				return _comparePose;
			}
			set
			{
				if (_comparePose == value)
				{
					return;
				}
				_comparePose = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("correctivePose")] 
		public CName CorrectivePose
		{
			get
			{
				if (_correctivePose == null)
				{
					_correctivePose = (CName) CR2WTypeManager.Create("CName", "correctivePose", cr2w, this);
				}
				return _correctivePose;
			}
			set
			{
				if (_correctivePose == value)
				{
					return;
				}
				_correctivePose = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("jointsToCompare")] 
		public CArray<CName> JointsToCompare
		{
			get
			{
				if (_jointsToCompare == null)
				{
					_jointsToCompare = (CArray<CName>) CR2WTypeManager.Create("array:CName", "jointsToCompare", cr2w, this);
				}
				return _jointsToCompare;
			}
			set
			{
				if (_jointsToCompare == value)
				{
					return;
				}
				_jointsToCompare = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		public animCorrectivePoseEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
