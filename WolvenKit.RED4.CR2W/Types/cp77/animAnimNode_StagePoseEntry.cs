using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StagePoseEntry : animAnimNode_Base
	{
		private CName _inputName;
		private animPoseLink _parentInput;

		[Ordinal(11)] 
		[RED("inputName")] 
		public CName InputName
		{
			get
			{
				if (_inputName == null)
				{
					_inputName = (CName) CR2WTypeManager.Create("CName", "inputName", cr2w, this);
				}
				return _inputName;
			}
			set
			{
				if (_inputName == value)
				{
					return;
				}
				_inputName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("parentInput")] 
		public animPoseLink ParentInput
		{
			get
			{
				if (_parentInput == null)
				{
					_parentInput = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "parentInput", cr2w, this);
				}
				return _parentInput;
			}
			set
			{
				if (_parentInput == value)
				{
					return;
				}
				_parentInput = value;
				PropertySet(this);
			}
		}

		public animAnimNode_StagePoseEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
