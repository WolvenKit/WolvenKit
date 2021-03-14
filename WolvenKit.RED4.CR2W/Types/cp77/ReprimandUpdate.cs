using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReprimandUpdate : redEvent
	{
		private CEnum<EReprimandInstructions> _reprimandInstructions;
		private entEntityID _target;
		private Vector4 _targetPos;
		private wCHandle<gameObject> _currentPerformer;

		[Ordinal(0)] 
		[RED("reprimandInstructions")] 
		public CEnum<EReprimandInstructions> ReprimandInstructions
		{
			get
			{
				if (_reprimandInstructions == null)
				{
					_reprimandInstructions = (CEnum<EReprimandInstructions>) CR2WTypeManager.Create("EReprimandInstructions", "reprimandInstructions", cr2w, this);
				}
				return _reprimandInstructions;
			}
			set
			{
				if (_reprimandInstructions == value)
				{
					return;
				}
				_reprimandInstructions = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public entEntityID Target
		{
			get
			{
				if (_target == null)
				{
					_target = (entEntityID) CR2WTypeManager.Create("entEntityID", "target", cr2w, this);
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
		[RED("targetPos")] 
		public Vector4 TargetPos
		{
			get
			{
				if (_targetPos == null)
				{
					_targetPos = (Vector4) CR2WTypeManager.Create("Vector4", "targetPos", cr2w, this);
				}
				return _targetPos;
			}
			set
			{
				if (_targetPos == value)
				{
					return;
				}
				_targetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currentPerformer")] 
		public wCHandle<gameObject> CurrentPerformer
		{
			get
			{
				if (_currentPerformer == null)
				{
					_currentPerformer = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "currentPerformer", cr2w, this);
				}
				return _currentPerformer;
			}
			set
			{
				if (_currentPerformer == value)
				{
					return;
				}
				_currentPerformer = value;
				PropertySet(this);
			}
		}

		public ReprimandUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
