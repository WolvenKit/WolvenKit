using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GraphSlot : animAnimNode_Base
	{
		private CName _name;
		private CBool _dontDeactivateInput;
		private animPoseLink _inputLink;

		[Ordinal(11)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("dontDeactivateInput")] 
		public CBool DontDeactivateInput
		{
			get
			{
				if (_dontDeactivateInput == null)
				{
					_dontDeactivateInput = (CBool) CR2WTypeManager.Create("Bool", "dontDeactivateInput", cr2w, this);
				}
				return _dontDeactivateInput;
			}
			set
			{
				if (_dontDeactivateInput == value)
				{
					return;
				}
				_dontDeactivateInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get
			{
				if (_inputLink == null)
				{
					_inputLink = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "inputLink", cr2w, this);
				}
				return _inputLink;
			}
			set
			{
				if (_inputLink == value)
				{
					return;
				}
				_inputLink = value;
				PropertySet(this);
			}
		}

		public animAnimNode_GraphSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
